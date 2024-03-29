﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_4;


//Испытание, Тест, Экзамен, Выпускной экзамен, Вопрос; 
class Test : Testing, ITest
{

    #region Constructors
    public Test()
    {
        Name = "Default";
        Time = 0;

    }


    public Test(string name, int time, int mark) : base(name, time)
    {
        Name = name;
        Time = time;

    }

    public Test(string name, int time) : base(name, time)
    {
    }
    #endregion

    #region Properties 



    public virtual string Type_challenges { get; set; }
    public virtual string Difficult { get; set; }
    #endregion

    #region Methods


    public override void Successfully()
    {
        base.Successfully();
    }
    public override void Failed()
    {
        Console.WriteLine(" Failed");
    }

    public override string ToString()
    {
        return base.ToString() + $"Type_challenges: {Type_challenges} Difficult: {Difficult}";

    }


    #endregion





}