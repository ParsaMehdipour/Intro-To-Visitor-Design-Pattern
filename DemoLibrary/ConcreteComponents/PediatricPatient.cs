using DemoLibrary.ComponentInterfaces;
using DemoLibrary.VisitorInterfaces;

namespace DemoLibrary.ConcreteComponents;

/// <summary>
/// Each Concrete Component must implement the `Accept` method in such a way
/// that it calls the visitor's method corresponding to the component's
/// class.
/// </summary>
public class PediatricPatient : IPatient
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string MedicalHistory { get; set; }
    public string GuardianName { get; set; }
    public string VaccinationRecord { get; set; }

    public PediatricPatient(string name, int age, string guardianName, string vaccinationRecord, string medicalHistory)
    {
        Name = name;
        Age = age;
        GuardianName = guardianName;
        VaccinationRecord = vaccinationRecord;
        MedicalHistory = medicalHistory;
    }

    // Note that we're calling `VisitPediatricPatient`, which matches the
    // current class name. This way we let the visitor know the class of the
    // component it works with.
    public void Accept(IHealthcareVisitor visitor)
    {
        visitor.VisitPediatricPatient(this);
    }
}
