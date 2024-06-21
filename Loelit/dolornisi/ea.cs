public class MyClass
{
    public List<PolynomItem> PolyItems { get; set; }

    public MyClass()
    {
        PolyItems = new List<PolynomItem>();
    }
}

public class PolynomItem
{
    // Properties and methods of the PolynomItem class
}

// Usage
MyClass myObject = new MyClass();
myObject.PolyItems.Add(new PolynomItem());
