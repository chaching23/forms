namespace view.Models
{

public class User
{
    public string FirstName {get;set;}
    public string LastName {get;set;}
}


public class cartoon
{
    public string name {get;set;}
    public int age {get;set;}

    public string show {get;set;}

    public bool IsOldSkool {get;set;}



    public cartoon(){


    }

    public cartoon(string name, int age, string show, bool IsOldSkool)
    {
        this.name=name;
        this.age=age;
        this.show=show;
        this.IsOldSkool=IsOldSkool;

    }

}





}