# Arina_Sarpilo_UI_RPG_B

RPG Spēles Projekts (OOP pamati)
Šis projekts ir izstrādāts kā mācību darbs, lai demonstrētu četrus galvenos objektorientētās programmēšanas (OOP) principus Unity vidē.

Realizētie OOP principi:
Inheritance (Mantošana):
Bāzes klase Character tiek izmantota, lai izveidotu Player un Enemy klases, koplietojot kopīgus mainīgos (piemēram, vārdu un veselību).
Abstraktā klase Weapon kalpo kā pamats dažādiem ieroču tipiem: PoisonWeapon, CommonWeapon un FreezingBow.
Encapsulation (Inkapsulācija):
Veselības sistēma ir aizsargāta, izmantojot private mainīgo un publisku īpašību (Property) Health.
Setterī ir iebūvēta loģika, kas neļauj veselībai nokrist zem 0, nodrošinot datu integritāti.
Abstraction (Abstrakcija):
Klase Weapon ir definēta kā abstract. Tas nozīmē, ka nevar izveidot "vispārīgu ieroci" — ir jāizveido konkrēts ieroča veids.
Tajā ir definēta abstraktā metode GetDamage(), kuru katrs ieroča veids realizē pēc savas loģikas.
Polymorphism (Polimorfisms):
Metožu pārlāde (Overloading): TakeDamage metodei ir divas versijas — viena pieņem tiešu bojājumu skaitli, otra pieņem Weapon objektu.
Metožu pārrakstīšana (Overriding): Katrs ierocis (Poison, Freezing, Common) pārraksta GetDamage() metodi, lai piešķirtu unikālus efektus (indēšana, iesaldēšana).

Izvēlētais papilduzdevums:
Realizēti 3 dažādi ieroču tipi, starp kuriem spēlētājs var pārslēgties:
CommonWeapon: Standarta bojājums.
PoisonWeapon: Nodara papildu indēšanas bojājumus ar ierobežotu lādiņu skaitu.
FreezingBow: Ieroča tips ar iespēju (chance) "iesaldēt" pretinieku un nodarīt palielinātu bojājumu.
