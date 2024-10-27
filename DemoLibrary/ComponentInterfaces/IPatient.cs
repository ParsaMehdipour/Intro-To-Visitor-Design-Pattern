using DemoLibrary.VisitorInterfaces;

namespace DemoLibrary.ComponentInterfaces;

/// <summary>
/// The Component interface declares an `accept` method that should take the
/// base visitor interface as an argument.
/// </summary>
public interface IPatient
{
    string Name { get; set; }
    int Age { get; set; }
    string MedicalHistory { get; set; }
    void Accept(IHealthcareVisitor visitor);
}
