using System;

namespace OOPSExample
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //Car sureshCar = new Car();
            //sureshCar.SetCarDetails("BMW", "3 series", "Sedan", "Black", 1000.17, 2019);

            //Car basantaCar = new Car();
            //basantaCar.SetCarDetails("Tesla", "Model 3", "Sedan", "Blue", 950.4, 2020);

            //Dog dog1 = new Dog("PQR", 40.1, false);
            //dog1.GetDogDetails();

            //Dog dog2 = new Dog("ABC", 26.4, true);
            //dog2.GetDogDetails();

            //Dog sureshDog = new Dog("Tuffy", 35, true);
            ////sureshDog.SetDogDetails("Tuffy", 35);
            //sureshDog.GetDogDetails();

            //Dog basantaDog = new Dog("Tommy", 40, false);
            ////basantaDog.SetDogDetails("Tommy", 40);
            //basantaDog.GetDogDetails();

            //TriangleShape triangleShape1 = new TriangleShape(4.5, 2.1);
            //triangleShape1.GetArea();

            //TriangleShape triangleShape2 = new TriangleShape(7, 2);
            //triangleShape2.GetArea();

            //RectangleShape rectangleShape1 = new RectangleShape(4, 3);
            //rectangleShape1.GetArea();

            //RightAngleTraingleShape rightAngleTraingleShape = new RightAngleTraingleShape(4, 6);
            //rightAngleTraingleShape.GetHypotenuseSide();
            //rightAngleTraingleShape.GetArea();

            //Person person1 = new Person("Vaibhav", 11);
            //person1.GetAge();

            //Person person2 = new Person("Gyanedra", 30);
            //person2.GetAge();

            string[] employee1TotalCompanies = { "Microsoft", "Google" };
            Employee employee1 = new Employee("E001", "Google", employee1TotalCompanies, "Vaibhav", 11);
            employee1.GetEmployeeHistory();

            string[] employee2TotalCompanies = { "Microsoft", "Google", "Amazon" };
            Employee employee2 = new Employee("E002", "Amazon", employee2TotalCompanies, "Gyanedra", 30);
            employee2.GetEmployeeHistory();

        }
    }
}
