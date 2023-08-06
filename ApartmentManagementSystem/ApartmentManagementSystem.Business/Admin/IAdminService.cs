using ApartmentManagementSystem.ApartmentManagementSystem.Business.Generic;
using ApartmentManagementSystem.Entities;

namespace ApartmentManagementSystem.ApartmentManagementSystem.Business.Admin
{
    public class IAdminService 
    {
        // AddApartmentInfo(Apartment apartment); //Add apartment
        //void AddUserInfo(User user);//Add user

        // add revenue and bill bilgilerini (monthly)
        //void AddBillInfo(Bill bill);
        //void AddRevenueInfo(Revenue revenue);


        // Gelen mesajları görüntüler.
        //List<Message> GetMessage();

        // Aylık borç-alacak listesini görüntüler.
        //List<DebtCreditInfo> GetDebtCreditInfo();

        // Kişileri listeler.
        //List<User> GetUserList();

        // Kişileri düzenler.
        //void UpdateUser(User user);

        // Kişileri siler.
        //void DeleteResidentInfo(int residentId);

        // Daire/konut bilgilerini listeler.
        //List<Apartment> GetApartmentList();

        // Daire/konut bilgilerini düzenler.
        //void UpdateApartmentInfo(ApartmentInfo apartmentInfo);

        // Daire/konut bilgilerini siler.
        //void DeleteApartmentInfo(int apartmentId);

        // Fatura ödemeyen kişilere günlük mail job'u atar.
        //void SendDailyReminderForUnpaidBills();
    }
}
