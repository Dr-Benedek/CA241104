using CA241104;
using System.Text;
List<Versenyzo> versenyzok = [];
using StreamReader sr = new(path: "..\\..\\..\\src\\forras.txt", encoding: Encoding.UTF8);

while (!sr.EndOfStream) versenyzok.Add(new(sr.ReadLine()));

Console.WriteLine($"versenyzők száma: {versenyzok.Count()} db");


//csop1
var f1 = versenyzok.Count(v => v.Kategoria == "elit");
Console.WriteLine($"1.Feladat: versenyzők száma elit kategóriában: {f1}");

var f2 = versenyzok.Where(v => !v.Nem).Average(v => DateTime.Now.Year - v.Szul);
Console.WriteLine($"2.Feladat: női versenyzők átlag életkora: {f2:0.00}");

var f3 = versenyzok.Sum(v => v.Versenyidok["kerékpár"].TotalHours);
Console.WriteLine($"3.Feladat: kerékpárral töltött össszidő: {f3:0.00} óra");

var f4 = versenyzok.Where(v => v.Kategoria == "elit junior").Average(v => v.Versenyidok["úszás"].TotalSeconds);
Console.WriteLine($"4.Feladat: elit junior átlagos uszási ideje: {f4/60:0.000} perc");

var f5 = versenyzok.Where(v => v.Nem).MinBy(v => v.OsszIdoSec);
Console.WriteLine($"5.Feladat: férfi győztes: {f5}");

var f6 = versenyzok.GroupBy(v => v.Kategoria).OrderBy(g => g.Key);
Console.WriteLine($"6.Feladat: versenyt befejezok száma (kategoria, fő, depo idő) ");
foreach (var f in f6)
{
    Console.WriteLine($"{f.Key,11}: {f.Count(),2} fő,  " +
        $"{f.Average(v=> v.Versenyidok["I. depó"].TotalMinutes + v.Versenyidok["II. depó"].TotalMinutes):0.000} perc");
}


Console.WriteLine($"\n\n----------\n\n");
//csop2
var cs2f1 = versenyzok.Count(v => v.Kategoria == "elit junior");
Console.WriteLine($"1.Feladat: versenyzők száma elit junior kategóriában: {cs2f1}");

var cs2f2 = versenyzok.Where(v => v.Nem).Average(v => DateTime.Now.Year - v.Szul);
Console.WriteLine($"2.Feladat: férfi versenyzők átlag életkora: {cs2f2:0.00}");

var cs2f3 = versenyzok.Sum(v => v.Versenyidok["futás"].TotalHours);
Console.WriteLine($"3.Feladat: futással töltött össszidő: {cs2f3:0.00} óra");

var cs2f4 = versenyzok.Where(v => v.Kategoria == "20-24").Average(v => v.Versenyidok["úszás"].TotalSeconds);
Console.WriteLine($"4.Feladat: 20-24 kategória átlagos uszási ideje: {cs2f4 / 60:0.000} perc");

var cs2f5 = versenyzok.Where(v => !v.Nem).MinBy(v => v.OsszIdoSec);
Console.WriteLine($"5.Feladat: női győztes: {cs2f5}");

var cs2f6 = versenyzok.GroupBy(v => v.Nem).OrderBy(g => g.Key);
Console.WriteLine($"6.Feladat: versenyt befejezok száma (Nem, fő, depó idő)");
foreach (var f in cs2f6)
{
    Console.WriteLine($"{(f.Key ? "férfi" : "nő")}: {f.Count(),2} fő, " +
        $"{f.Average(v=> v.Versenyidok["I. depó"].TotalMinutes + v.Versenyidok["II. depó"].TotalMinutes):0.000} perc");
}


Console.WriteLine($"\n\n----------\n\n");
//csop3
var cs3f1 = versenyzok.Count(v => v.Kategoria == "25-29");
Console.WriteLine($"1.Feladat: versenyzők száma 25-29 kategóriában: {cs3f1}");

var cs3f2 = versenyzok.Average(v => DateTime.Now.Year - v.Szul);
Console.WriteLine($"2.Feladat: versenyzők átlag életkora: {cs3f2:0.00}");

var cs3f3 = versenyzok.Sum(v => v.Versenyidok["úszás"].TotalHours);
Console.WriteLine($"3.Feladat: úszás töltött össszidő: {cs3f3:0.00} óra");

var cs3f4 = versenyzok.Where(v => v.Kategoria == "elit").Average(v => v.Versenyidok["úszás"].TotalSeconds);
Console.WriteLine($"4.Feladat: elit kategória átlagos uszási ideje: {cs3f4 / 60:0.000} perc");

var cs3f5 = versenyzok.Where(v => v.Nem).MinBy(v => v.OsszIdoSec);
Console.WriteLine($"5.Feladat: férfi győztes: {cs3f5}");

var cs3f6 = versenyzok.GroupBy(v => v.Kategoria).OrderBy(g => g.Key);
Console.WriteLine($"6.Feladat: versenyt befejezok száma (kategoria, fő, depó idő)");
foreach (var f in f6)
{
    Console.WriteLine($"{f.Key,11}: {f.Count(),2} fő,  " +
        $"{f.Average(v=> v.Versenyidok["I. depó"].TotalMinutes + v.Versenyidok["II. depó"].TotalMinutes):0.000} perc");
}
