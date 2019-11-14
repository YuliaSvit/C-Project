using System;
using System.Collections.Generic;
using System.Text;

namespace Car
{
    class Car
    {  
    //////////private variables////////
    string color;
    int numOfDoors;
    bool isConvertible;

    ///////////Constructor//////////
    //Doesn't have  return type, and should be named as class
    public Car(string colorC, int numOfDoorsC, bool isConvertibleC)
    {
        Color = colorC;
        NumOfDoors = numOfDoorsC;
        IsConvertible = isConvertibleC;
    }
    //we can set up as many Constructors as we can (if none- then it will be autoimplemented as empty

    public Car()
    { }

    ////////////Properties: get set acessors////////////
    //behind the scenes in .Net Framework (string value ) is being passed:
    //public string Color(string value)
    public string Color
    {
        get
        { return color; }
        set
        { color = value; }
    }
    //if we are npt doing any validations we can write the code smaller(called "auto-implemented properties:
    public bool IsConvertible
    { get; set; }

    //property with the validation
    public int NumOfDoors
    {
        get { return numOfDoors; }
        set
        {
            if (value <= 4)
            {
                numOfDoors = value;
            }
            else
            {
                Console.WriteLine("Incorrect # of doors");
            }
        }
    }
    //////////methods///////////
    public void Accelarate()
    {
        Console.WriteLine("I am accelarating");
    }

    public bool FamilyCar()
    {
        if ((NumOfDoors > 2)&&(NumOfDoors<=4))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
}