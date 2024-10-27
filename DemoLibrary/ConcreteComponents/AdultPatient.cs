using DemoLibrary.ComponentInterfaces;
using DemoLibrary.VisitorInterfaces;

namespace DemoLibrary.ConcreteComponents;

/// <summary>
/// Each Concrete Component must implement the `Accept` method in such a way
/// that it calls the visitor's method corresponding to the component's
/// class.
/// </summary>
public class AdultPatient : IPatient
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string MedicalHistory { get; set; }
    public string Occupation { get; set; }
    public string LifestyleFactors { get; set; }

    public AdultPatient(string name, int age, string occupation, string lifestyleFactors, string medicalHistory)
    {
        Name = name;
        Age = age;
        Occupation = occupation;
        LifestyleFactors = lifestyleFactors;
        MedicalHistory = medicalHistory;
    }

    public void Accept(IHealthcareVisitor visitor)
    {
        visitor.VisitAdultPatient(this);
    }
}