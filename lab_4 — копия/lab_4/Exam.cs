using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_4;
//Испытание, Тест, Экзамен, Выпускной экзамен, Вопрос; 
class Exam : Test
{

    #region Fields
    protected string _mark;
    #endregion


    #region Constructor
    public Exam(string name, int time) : base(name, time)
    {
        Name = name;
        Time = time;

    }
    #endregion
    #region Propertis

    public string Mark
    {
        get => _mark;
        set => _mark = value;
    }
    public virtual string Teacher { get; set; }

    #endregion

    #region Methods

    public override void Successfully()
    {
        base.Successfully();
        Console.WriteLine("Exam Successfully");
    }

    // ToString
    public override string ToString()
    {
        return $"Teacher: {Teacher}, Mark: {Mark}";
    }
    #endregion

}

class Final_exam : Exam
{

    public Final_exam(string name, int time) : base(name, time)
    {
        Name = name;
        Time = time;

    }
    #region Propertis
    public virtual string Subject { get; set; }
    #endregion endregion

    #region Methods
    public override void Successfully()
    {
        base.Successfully();
        Console.WriteLine("Final_exam Successfully");
    }

    // ToString
    public override string ToString()
    {
        return $"Subject: {Subject}, Teacher: {Teacher}, Mark: {Mark}";
    }
    #endregion
}