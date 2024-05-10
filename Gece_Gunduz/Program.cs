







        Console.WriteLine("Gece insanı mı yoksa gündüz insanı mı olduğunu öğrenmek için bu testi yapın!");

        int geceCevapSayisi = 0;
        int gunduzCevapSayisi = 0;

        Console.WriteLine("1. Gece geç saatlere kadar uyanık kalır mısınız? (E/H)");
        if (Console.ReadLine().ToUpper() == "E")
            geceCevapSayisi++;

        Console.WriteLine("2. Sabahları uyanmak size zor mu gelir? (E/H)");
        if (Console.ReadLine().ToUpper() == "E")
            geceCevapSayisi++;

        Console.WriteLine("3. En üretken olduğunuz zaman genellikle gece saatleri midir? (E/H)");
        if (Console.ReadLine().ToUpper() == "H")
            gunduzCevapSayisi++;

        Console.WriteLine("4. Gündüz uyandığınızda kendinizi enerjik hisseder misiniz? (E/H)");
        if (Console.ReadLine().ToUpper() == "E")
            gunduzCevapSayisi++;

        Console.WriteLine("5. Hafta sonları genellikle geç mi eve gelirsiniz? (E/H)");
        if (Console.ReadLine().ToUpper() == "H")
            gunduzCevapSayisi++;

        // Sonucu gösterelim
        Console.WriteLine("\nTesti tamamladınız. İşte sonuçlarınız:");
        if (geceCevapSayisi > gunduzCevapSayisi)
            Console.WriteLine("Gece insanısınız!");
        else if (gunduzCevapSayisi > geceCevapSayisi)
            Console.WriteLine("Gündüz insanısınız!");
        else
            Console.WriteLine("Ne gece insanı ne de gündüz insanı olma eğiliminiz var gibi gözüküyor!");



