using System;


class Program
{
    public static void Main()
    {
        //Getter and Setter Methods
        Student_GetSet S1 = new Student_GetSet();
        S1.setId(101);
        S1.setName("Ramesh");
        Console.WriteLine("\nID : {0}\nName : {1}\nPercentage: {2}",S1.getId(), S1.getName(), S1.getPercentage());

        //Properties
        Student_Properties S2 = new Student_Properties();
        S2.id = 102;
        S2.name = "Suresh";
        Console.WriteLine("\nID : {0}\nName : {1}\nPercentage: {2}", S2.id, S2.name, S2.percentage);

        //Auto-Implemented Properties
        Student_Auto S3 = new Student_Auto();
        S3.id = 103;
        S3.city = "Hubli";
        S3.email = "lavesh@gmail.com";
        S3.gender = "Male";
        Console.WriteLine("\nID : {0}\nCity : {1}\nEmail: {2}\nGender: {3}", S3.id, S3.city, S3.email, S3.gender);

    }
}


//Getter and Setter Methods
class Student_GetSet
{
    private int _id;
    private string _name;
    private float _percentage = 75.6f;

    public void setId(int id)
    {
        if (id<=0)
        {
            throw new Exception("Id can't be less than or equal to zero");
        } 
        this._id = id;
    }

    public int getId()
    {
        return this._id;
    }


    public void setName(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new Exception("Name can't be NULL or empty");
        }
        this._name = name;
    }

    public string getName()
    {
        return string.IsNullOrEmpty(this._name) ? "No Name Provided" : this._name;
    }


    public float getPercentage()
    {
        return this._percentage;
    }
}


//Properties
class Student_Properties
{
    private int _id; 
    private string _name;
    float _percentage = 75.6f;                  //By default private

    public int id       
    {
        get{                                    //We use get and set accessors to set Properties
            return this._id;                    //The values we assign to these properties in main in present in built-in 'value' keyword
        }
        set{
            if (value<=0)
            {
                throw new Exception("Id can't be less than or equal to zero");
            } 
            this._id = value; 
        }
    }

    public string name
    {
        get{
            return string.IsNullOrEmpty(this._name) ? "No Name Provided" : this._name;
        }
        set{
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Name can't be NULL or empty");
            }
            this._name = value;  
        }
    }

    public float percentage
    {
        get{
            return this._percentage;
        }
    }
    
}


//Auto-Implementated Properties
class Student_Auto
{
    private int _id;
    
    public string email{ get; set;}                   //From C# 3.0 we have Auto-implemented Properties 
    public string city { get; set;}                   //Here there is no need to explicitly declare a private variable and provide get and set accessors
    public string gender { get; set;}                 //Here, the compiler autom creates private variable and assigns get and set, if we follow the syntax shown
                                                      //But here we can't perform any validation/checking of data, it acts as normal get and set
    public int id
    {
        get{
            return this._id;
        }
        set{
            if (value<=0)
            {
                throw new Exception("Id can't be less than or equal to zero");
            } 
            this._id = value; 
        }
    }

}