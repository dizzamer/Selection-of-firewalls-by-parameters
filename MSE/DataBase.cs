using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace MSE
{
    public class DataBase
    {
        /// <summary>
        /// Оператор сравнения
        /// </summary>
        public enum CompareTerm { COMPARE_GREATER, COMPARE_GREATER_EQUAL, COPMARE_EQUAL, COMPARE_LESS, COMPARE_LESS_EQUAL, VALUES_COUNT };

        /// <summary>
        /// Константа определяющая имя параметра, используемого в качестве цены
        /// </summary>
        public static string PRICE_STRING_CONST = "Стоимость";

        /// <summary>
        /// Элемент базы данных
        /// </summary>
        public class DataBaseItem
        {
            public DataBaseItem()
            {

            }
            /// <summary>
            /// Имя
            /// </summary>
            public String name;
            /// <summary>
            /// Словарь параметров: ключ - имя, значение - значение
            /// </summary>
            public Dictionary<String, int> parameters;

            public override string ToString()
            {
                return name;
            }
        }

        /// <summary>
        /// Параметр поиск
        /// </summary>
        public class SearchParameter
        {
            public SearchParameter() { }
            /// <summary>
            /// Ключ (имя параметра)
            /// </summary>
            public String key;
            /// <summary>
            /// Значение для поиска
            /// </summary>
            public int value;
            /// <summary>
            /// Оператор сравнения
            /// </summary>
            public CompareTerm term;
        }

        public System.ComponentModel.BindingList<DataBaseItem> items;

        /// <summary>
        /// Оператор доступа по индексу
        /// </summary>
        /// <param name="index"> Индекс элемента</param>
        /// <returns> Элемент </returns>
        public DataBaseItem this[int index]
        {
            get { return items[index]; }
            set { items[index] = value; }
        }

        /// <summary>
        /// Количество элементов в базе данных
        /// </summary>
        public int Count
        {
            get { return items.Count; }
        }

        public DataBase()
        {
            items = new System.ComponentModel.BindingList<DataBaseItem>();
        }        
        

        /// <summary>
        /// Функция сохранения в файл
        /// </summary>
        /// <param name="filename"> Имя файла</param>
        public void saveToFile(String filename = "db")
        {
            XmlWriterSettings settings = new XmlWriterSettings(); // Настройка
            settings.Indent = true;
            settings.IndentChars = "\t";
            XmlWriter writer = XmlWriter.Create(filename, settings);
            writer.WriteStartDocument();
            writer.WriteStartElement("database");
            foreach (var item in items) // заполнение структуры документа
            {
                writer.WriteStartElement("MSE");
                writer.WriteAttributeString("name", item.name);
                foreach (var param in item.parameters)
                {
                    writer.WriteStartElement("parameter");
                    writer.WriteAttributeString("name", param.Key);
                    writer.WriteAttributeString("param", param.Value.ToString());
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Flush(); // сохранение
            writer.Close();
        }


        /// <summary>
        /// Функция загрузки базы данных из файла
        /// </summary>
        /// <param name="filename"> Имя файла</param>
        public void LoadFromFile(String filename = "db")
        {
            if (!System.IO.File.Exists(filename)) // проверка на наличие файла
                return;
            if (items == null)
                items = new System.ComponentModel.BindingList<DataBaseItem>();
            items.Clear();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(System.IO.File.ReadAllText(filename)); // загрузка xml документа из файла
            var nodes = doc.GetElementsByTagName("MSE"); // корневой элемент
            foreach (XmlNode node in nodes)
            {
                DataBaseItem item = new DataBaseItem(); // создание элемента
                if (node.Attributes["name"] != null)
                    item.name = node.Attributes["name"].Value;
                item.parameters = new Dictionary<string, int>(); // создание и заполнение параметров элемента
                foreach (XmlNode param in node.SelectNodes("parameter"))
                {
                    if (param.Attributes["name"] != null && param.Attributes["param"] != null) // проверка на валидность записи
                    {
                        item.parameters.Add(param.Attributes["name"].Value, Convert.ToInt32(param.Attributes["param"].Value));
                    }
                }
                items.Add(item);
            }
        }

        public void AddItem(DataBaseItem item)
        {
            items.Add(item);
        }

        public void DeleteItem(DataBaseItem item)
        {
            if (item != null)
                items.Remove(item);
        }

        public void DeleteItem(int i)
        {
            if (items.Count > i)
                items.RemoveAt(i);
        }


        /// <summary>
        /// Функция поиска элемента в базе данных
        /// </summary>
        /// <param name="parameters"> Параметры поиска</param>
        /// <returns> Массив из двух элементов [0] - результат по цене или null, [1] - результат по остальным параметрам или null</returns>
        public List<DataBaseItem> search(List<SearchParameter> parameters)
        {
            List<DataBaseItem> res = new List<DataBaseItem>();
            if (parameters.SingleOrDefault(param => param.key == PRICE_STRING_CONST) != null) // выбор параметра - цены, если такой параметр есть в списке
            {
                res.Add(match(items.ToList(), parameters).OrderBy(item => item.parameters[PRICE_STRING_CONST]).ElementAtOrDefault(0));
            }
            // поиск по наилучшему совпадению без учета цены
            var r = bestMatch(match(items.ToList(), parameters.Where(item => item.key != PRICE_STRING_CONST).ToList()), parameters.Where(item => item.key != PRICE_STRING_CONST).ToList());
            res.Add(r);
            return res;
        }

        /// <summary>
        /// Функция нахождения наилушего совпадения
        /// </summary>
        /// <param name="list">Список элементов для поиска</param>
        /// <param name="parameters"> Список параметров поиска</param>
        /// <returns>Элемент максимально соответствующий условиям</returns>
        private DataBaseItem bestMatch(List<DataBaseItem> list, List<SearchParameter> parameters, SearchParameter mainParameter = null)
        {
            Dictionary<DataBaseItem, float> deltas = new Dictionary<DataBaseItem, float>(); // дельты - сумма отклонений параметров от исходных для данного элемента
            foreach(var item in list)
            {
                foreach (var p in parameters)
                {
                    if (item.parameters.ContainsKey(p.key)) //проверка на соответствие условию
                    {
                        if (deltas.ContainsKey(item)) // добавление дельты по данному условию
                        {
                            deltas[item] += (int)Math.Abs((item.parameters[p.key] - p.value) / p.value);
                        }
                        else
                        {
                            deltas.Add(item, (int)Math.Abs((item.parameters[p.key] - p.value) / p.value));
                        }
                    }
                }
            }
            if (deltas.Count > 0) // если найдены соответствия
            {
                float tmp = deltas.Min(item => item.Value); // выбираем наименьшее отклонение
                return deltas.FirstOrDefault(item => item.Value == tmp).Key;
            }
            return null;
        }

        private List<DataBaseItem> match(List<DataBaseItem> list, List<SearchParameter> parameters)
        {
            List<DataBaseItem> res = new List<DataBaseItem>();
            foreach (var item in list)
            {
                bool accept = true;
                foreach (var p in parameters)
                {
                    if (!item.parameters.ContainsKey(p.key) || !compare(p.value, item.parameters[p.key], p.term)) //проверка на соответствие условию
                    {
                        accept = false;
                        break;
                    }
                }
                if (accept)
                    res.Add(item);
            }
            return res;
        }

        /// <summary>
        /// Функция сравнения двух чисел
        /// </summary>
        /// <param name="first">первый операнд</param>
        /// <param name="second">второй операнд</param>
        /// <param name="term">оператор сравнения</param>
        /// <returns>true если (не)равенство верное</returns>
        private bool compare(int first, int second, CompareTerm term = CompareTerm.COPMARE_EQUAL)
        {
            switch (term) // сравнение операндов в соответствии с условием сравнения
            {
                case CompareTerm.COMPARE_GREATER:
                    return second > first;
                case CompareTerm.COMPARE_GREATER_EQUAL:
                    return second >= first;
                case CompareTerm.COPMARE_EQUAL:
                    return second == first;
                case CompareTerm.COMPARE_LESS_EQUAL:
                    return second <= first;
                case CompareTerm.COMPARE_LESS:
                    return second < first;
                default:
                    return false;
            }
        }
        
    }
}
