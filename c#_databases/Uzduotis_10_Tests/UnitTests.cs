using Microsoft.EntityFrameworkCore;
using Uzduotis_10;
using Uzduotis_10.Entities;
using Uzduotis_10.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uzduotis_10.Repositories;

namespace Uzduotis_10_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestClass]
        public class PatientServiceTests
        {
            private HospitalContext _context;
            private DbContextOptions<HospitalContext> _options;
            private PatientRepository _patientRepository;

            [TestInitialize]
            public void OnInit()
            {
                _options = new DbContextOptionsBuilder<HospitalContext>()
                    .UseInMemoryDatabase(databaseName: "TestDatabase")
                    .Options;
                _context = new HospitalContext(_options);
                _context.Database.EnsureDeleted();
                _context.Database.EnsureCreated();
                _patientRepository = new PatientRepository(_context);

                using (var context = new HospitalContext(_options))
                {
                    context.Pacientai.AddRange(
                        new Pacientas { Vardas = "Jonas", Pavarde = "Jonaitis", GimimoData = new DateTime(1985, 6, 15) },
                        new Pacientas { Vardas = "Rimantas", Pavarde = "Rimkevièius", GimimoData = new DateTime(1988, 7, 17) },
                        new Pacientas { Vardas = "Petras", Pavarde = "Petraitis", GimimoData = new DateTime(1990, 8, 22) },
                        new Pacientas { Vardas = "Aistë", Pavarde = "Aleksaitë", GimimoData = new DateTime(1978, 12, 5) },
                        new Pacientas { Vardas = "Lina", Pavarde = "Linauskienë", GimimoData = new DateTime(1992, 3, 30) },
                        new Pacientas { Vardas = "Rimantas", Pavarde = "Rimkevièius", GimimoData = new DateTime(1988, 7, 17) }
                    );
                    context.SaveChanges();
                }
            }

            //1.

            [TestMethod]
            public void AddPatient_ValidPatient_ReturnsId()
            {
                // Arrange
                var patient = new Pacientas
                {
                    Vardas = "John",
                    Pavarde = "Doe",
                    GimimoData = new DateTime(1990, 1, 1)
                };

                // Act
                var result = _patientRepository.AddPatient(patient);

                // Assert
                Assert.AreNotEqual(0, result);  
            }

            [TestMethod]
            public void AddPatient_NameIsNull_ReturnsZero()
            {
                // Arrange
                var patient = new Pacientas
                {
                    Vardas = null,
                    Pavarde = "Doe",
                    GimimoData = new DateTime(1990, 1, 1)
                };

                // Act
                var result = _patientRepository.AddPatient(patient);

                Assert.AreEqual(0, result);
            }

            [TestMethod]
            public void AddPatient_SurnameIsNull_ReturnsZero()
            {
                // Arrange
                var patient = new Pacientas
                {
                    Vardas = "John",
                    Pavarde = null,
                    GimimoData = new DateTime(1990, 1, 1)
                };

                // Act
                var result = _patientRepository.AddPatient(patient);

                // Assert
                Assert.AreEqual(0, result);  
            }
      
            [TestMethod]
            public void AddPatient_DateOfBirthInFuture_ReturnsZero()
            {
                // Arrange
                var patient = new Pacientas
                {
                    Vardas = "John",
                    Pavarde = "Doe",
                    GimimoData = DateTime.Now.AddYears(1) 
                };

                // Act
                var result = _patientRepository.AddPatient(patient);

                // Assert
                Assert.AreEqual(0, result); 
            }

            [TestMethod]
            public void AddPatient_DateOfBirthIsNull_ReturnsZero()
            {
                // Arrange
                var patient = new Pacientas
                {
                    Vardas = "John",
                    Pavarde = "Doe",
                    GimimoData = null
                };

                // Act
                var result = _patientRepository.AddPatient(patient);

                // Assert
                Assert.AreEqual(0, result);  
            }

            //2

            [TestMethod]
            public void GetPatientById_ReturnsPatientWithId1_WhenIdIs1()
            {
                // Arrange
                using (var context = new HospitalContext(_options))
                {
                    // Act
                    var result = _patientRepository.GetPatientById(1); 

                    // Assert
                    Assert.IsNotNull(result);
                    Assert.AreEqual(1, result.Id); 
                    Assert.AreEqual("Jonas", result.Vardas);
                }
            }

            [TestMethod]
            public void GetPatientById_ReturnsNull_WhenIdIs0()
            {
                // Arrange
                using (var context = new HospitalContext(_options))
                {
                    // Act
                    var result = _patientRepository.GetPatientById(0);

                    // Assert
                    Assert.IsNull(result);
                }
            }

            [TestMethod]
            public void GetPatientById_ReturnsNull_WhenIdDoesNotExist()
            {
                // Arrange
                using (var context = new HospitalContext(_options))
                {
                    // Act
                    var result = _patientRepository.GetPatientById(999);

                    // Assert
                    Assert.IsNull(result);
                }
            }
        }
    }
}