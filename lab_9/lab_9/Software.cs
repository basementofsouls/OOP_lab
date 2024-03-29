﻿
namespace Lab_9;
class Software
{
    #region Property 
    public string Name { get; set; }
    public string Version { get; set; }
    public string Developer { get; set; }
    public string License { get; set; }
    public string Language { get; set; }
    #endregion

    #region Constructor
    public Software(string name, string version, string developer, string license, string language)
    {
        Name = name;
        Version = version;
        Developer = developer;
        License = license;
        Language = language;
    }
    #endregion

    #region Methods 

    public override string ToString()
    {
        return $"Name: {Name}, Version: {Version}, Developer: {Developer}, License: {License}, Language: {Language}";
    }
    public override bool Equals(object obj)
    {
        if (obj is Software software)
        {
            return Name == software.Name && Version == software.Version && Developer == software.Developer && License == software.License && Language == software.Language;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return Name.GetHashCode() ^ Version.GetHashCode() ^ Developer.GetHashCode() ^ License.GetHashCode() ^ Language.GetHashCode();
    }
    #endregion

}

/*1. Создайте класс по варианту, определите в нем свойства и методы, реализуйте
указанный интерфейс и другие при необходимости, соберите объекты класса в
коллекцию (можно сделать специальных класс с вложенной коллекцией и
методами ею управляющими), продемонстрируйте работу с ней
(добавление/удаление/поиск/вывод:
*/
/*7 Программное
обеспечение
IList<T> SortedList < TKey,
TValue>*/


interface IList<Tkey, TValue>
{

    void Add(Tkey key, TValue value);
    void Remove(Tkey key);

}
class SortedList<TKey, TValue> : IList<TKey, TValue>

{
    #region Fields 

    private Data[] _data;
    private int _count;
    private int _index;

    #endregion

    #region Constructor
    public SortedList(int _count)
    {
        _data = new Data[_count];
        _index = -1;
    }
    #endregion

    #region Methods 
    public void Add(TKey key, TValue value)
    {

        if (_index == _data.Length - 1)
        {
            throw new Exception("List is full");
        }

        _data[++_index] = new Data(key, value);
    }


    public void Remove(TKey key)
    {
        for (int i = 0; i < _data.Length; i++)
        {
            if (_data[i].Key.Equals(key))
            {
                for (int j = i; j < _data.Length - 1; j++)
                {
                    _data[j] = _data[j + 1];
                }
                _index--;
                return;
            }
        }
        throw new Exception("Key not found");
    }
    #endregion

    #region
    public TValue this[TKey key]
    {
        get
        {
            for (int i = 0; i < _data.Length; i++)
            {
                if (_data[i].Key.Equals(key))
                {
                    return _data[i].Value;
                }
            }
            throw new Exception("Key not found");
        }
        set
        {
            for (int i = 0; i < _data.Length; i++)
            {
                if (_data[i].Key.Equals(key))
                {
                    _data[i].Value = value;
                    return;
                }
            }
            throw new Exception("Key not found");
        }
    }
    #endregion






    class Data
    {
        #region Property 

        public TKey Key { get; set; }
        public TValue Value { get; set; }
        #endregion
        #region Constructor
        public Data(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }
        #endregion
        #region Methods
        public override string ToString() => $"Key: {Key}, Value: {Value}";

        #endregion

    }
}
