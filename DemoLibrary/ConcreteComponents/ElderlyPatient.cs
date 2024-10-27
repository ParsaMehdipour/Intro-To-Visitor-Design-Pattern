using DemoLibrary.ComponentInterfaces;
using DemoLibrary.VisitorInterfaces;

namespace DemoLibrary.ConcreteComponents;

/// <summary>
/// Each Concrete Component must implement the `Accept` method in such a way
/// that it calls the visitor's method corresponding to the component's
/// class.
/// </summary>
public class ElderlyPatient : IPatient
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string MedicalHistory { get; set; }
    public List<string> CurrentMedications { get; set; }
    public string EmergencyContact { get; set; }

    public ElderlyPatient(string name, int age, List<string> medications, string emergencyContact, string medicalHistory)
    {
        Name = name;
        Age = age;
        CurrentMedications = medications;
        EmergencyContact = emergencyContact;
        MedicalHistory = medicalHistory;
    }

    public void Accept(IHealthcareVisitor visitor)
    {
        visitor.VisitElderlyPatient(this);
    }
}
