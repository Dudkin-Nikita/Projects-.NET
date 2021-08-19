using System;

// до-диез первой октавы
var c = new Key(Note.C, Accidental.Sharp, Octave.Fifth);
Console.WriteLine(c.Note);
Console.WriteLine(c.Accidental);
Console.WriteLine(c.Octave);
Console.WriteLine(c); // C# (First)
Console.ReadLine();

// ре-бемоль первой октавы
var d = new Key(Note.D, Accidental.Flat);
Console.WriteLine(d.Note);
Console.WriteLine(d.Accidental);
Console.WriteLine(d.Octave);
Console.WriteLine(d); // Db (First)
Console.ReadLine();

Console.WriteLine(c.Equals(d)); // True
Console.WriteLine(c.CompareTo(d)); // 0
Console.ReadLine();

// до-бемоль первой октавы (что бы это значило?)
var x = new Key(Note.C, Accidental.Flat);
Console.WriteLine(x.Note);
Console.WriteLine(x.Accidental);
Console.WriteLine(x.Octave);
Console.WriteLine(x);
Console.ReadLine();

// си малой октавы
var y = new Key(Note.B, Accidental.Natural, Octave.Fifth);
Console.WriteLine(y.Note);
Console.WriteLine(y.Accidental);
Console.WriteLine(y.Octave);
Console.WriteLine(y);
Console.ReadLine();

Console.WriteLine(x.Equals(y)); // True
Console.WriteLine(x.CompareTo(c)); // -2
Console.ReadLine();

var defaultKey = new Key();
Console.WriteLine(defaultKey);
Console.ReadLine();

// var err = new Key(Note.A, (Accidental)1000);