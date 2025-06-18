
Console.WriteLine("Rüya Manavına Hoş Geldiniz!");
Console.WriteLine("--------------------------------------------");
Console.WriteLine("Elma = 2TL");
Console.WriteLine("Armut = 3TL");
Console.WriteLine("Çilek = 2TL");
Console.WriteLine("Muz = 3TL");
Console.WriteLine("Diğer bütün meyveler = 4Tl");
Console.WriteLine("Hangi meyveyi almak istersiniz? (Elma/Armut/Çilek/Muz/Diğer):");

// Kullanıcıdan meyve seçimini alıyoruz
string meyveler = Console.ReadLine();

// Kullanıcının girdiği meyve ismini küçük büyük harfe çeviriyoruz.
meyveler = meyveler.ToLower();

// Girilen meyve ismini denetliyoruz
if (meyveler=="elma"||meyveler=="armut"||meyveler=="çilek"||meyveler=="muz"||meyveler=="diğer")
{
    //Denetlenen isime göre fiyatını ekrana yazdırıyoruz.
    switch (meyveler)
	{
		case "elma":
			Console.WriteLine("Elma seçtiniz. Fiyatı 2 TL.");
			break;
		case "armut":
			Console.WriteLine("Armut seçtiniz. Fiyatı 3 TL.");
			break;
		case "çilek":
            Console.WriteLine("Çilek seçtiniz. Fiyatı 2 TL.");
			break;
		case "muz":
            Console.WriteLine("Muz seçtiniz. Fiyatı 3 TL");
			break;
        default:
			Console.WriteLine("Diğer meyve seçtiniz. Fiyatı 4 TL.");
            break;
	}
	//Girilen meyve ismi seçenekler arasında yoksa hata mesajını yolluyoruz.
}else
{
	Console.WriteLine("Geçersiz meyve seçimi. Lütfen Elma, Armut, Çilek, Muz veya Diğer seçeneklerinden birini girin.");
}
