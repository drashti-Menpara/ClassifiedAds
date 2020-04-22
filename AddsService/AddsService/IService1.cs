using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AddsService;

namespace AddsService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        bool addElectornics(Electronic name);
        [OperationContract]
        bool addCategory(Category category);
        [OperationContract]
        bool addCar(Car cars);
        [OperationContract]
        bool addBook(Book books);


        [OperationContract]
        int UpdateElectonics(Electronic id);
        [OperationContract]
        int UpdateCar(Car id);
        [OperationContract]
        int UpdateBook(Book id);


        [OperationContract]
        bool getCategory(Category id);

        [OperationContract]
        List<Car> getcar();
        [OperationContract]
        List<Electronic> GetLaptop();

        [OperationContract]
        List<Electronic> GetMobile();

        [OperationContract]
        List<Book> GetBooks();

        [OperationContract]
        List<Electronic> GetElectronics();


        [OperationContract]
        Car GetoneCar(int Id);

        [OperationContract]
        string deletcar(int Id);

       
       
        [OperationContract]
        string deleteElectronics(int Id);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
   
}
