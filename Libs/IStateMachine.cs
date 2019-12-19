using System;
using System.Collections.Generic;

public interface IStateMachine{
    Dictionary<string,Tuple<string,bool,DateTime>> State{get;set;}
}