using ClassLibrary.Data;
using ClassLibrary.Models;

LottoContext _context = new LottoContext();

if (!_context.Jatekos.Any()) {
    var sorok = File.ReadAllLines(@"c:/adat/nevek.csv").Skip(1);
    foreach (var line in sorok)
    {
        _context.Jatekos.Add(new Jatekos(line));
    }
    await _context.SaveChangesAsync();
}

if (!_context.Tipp.Any()) {
    var sorok = File.ReadAllLines(@"c:/adat/l5.csv").Skip(1);
    foreach (var line in sorok)
    {
        _context.Tipp.Add(new Tipp(line));
    }
    await _context.SaveChangesAsync();
}

Console.WriteLine("Adat feltöltés befejeződött!");