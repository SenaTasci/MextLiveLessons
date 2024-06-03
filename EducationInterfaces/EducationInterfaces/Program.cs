

using EducationInterfaces.Concretes;

KocaeliUniversity kocaeliUniversity = new KocaeliUniversity();

kocaeliUniversity.Grade1 = 100;

kocaeliUniversity.Grade2 = 90;

double calculateGrade = kocaeliUniversity.CalculateGrade();

Console.WriteLine($" Kocaeli Üniversitesi : {calculateGrade}");

GebzeTeknik gebzeTeknik = new GebzeTeknik();

gebzeTeknik.Grade1 = 70;

gebzeTeknik.Grade2 = 80;

double calculateGrade2 = gebzeTeknik.CalculateGrade();

Console.WriteLine($" Gebze Teknik : {calculateGrade2}");