// See https://aka.ms/new-console-template for more information
using BusinessLayer.Concrete;
using DataAccess.Entity;



DoctorRepository d = new DoctorRepository();
PoliclinicRepository p=new PoliclinicRepository();
//Poliklinik poliklinik = new Poliklinik()
//{
//    Name="Kadın Doğum"

//};
//Console.WriteLine(p.Create(poliklinik));

//Poliklinik update = new Poliklinik()
//{
//    ID = 3,
//    Name = "Üroloji"
//};
//Console.WriteLine(p.Update(update));

foreach (var item in p.GetAll())
{
    Console.WriteLine(+item.ID+" "+item.Name);
}

Console.Read();

//Doktor Doktor = new Doktor()
//{
//    FirstName="Ferhat",
//    LastName="Göcer",

//};
