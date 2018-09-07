using System;
using System.Collections.Generic;
using System.Text;

namespace NET_learning_2
{
    interface IFace
    {
        void Hehe();
        int Err { get; set; }
    }
    
}

abstract class CLAS
{
    abstract public void Lala();
    public int a;
    protected int Aa { get; set; }
    event EventHandler NewEvent;
}