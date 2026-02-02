
Wizard WizardA = new Wizard("nenek penyihir", 20);
Wizard WizardB = new Wizard("Voldemort", 30);

Console.WriteLine("permainan dimulai... \n");
WizardA.ShowStats();
WizardB.ShowStats();

WizardA.Attack(WizardB);
WizardB.Attack(WizardA);
WizardA.Attack(WizardB);

Console.WriteLine("permainan berakhir... \n");
WizardA.ShowStats();
WizardB.ShowStats();

WizardA.Attack(WizardB);
WizardB.Attack(WizardA);
WizardA.Attack(WizardB);


public class Wizard
{
    //deklarasi field
    public string Name;
    public int Energy;
    public int Damage;

    //deklarasi constructor
    public Wizard(string name, int damage)
    {
        Name = name;
        Energy = 100;    
        Damage = damage;
    }

    public void ShowStats()
    {
        Console.WriteLine("Statistik wizard");
        Console.WriteLine($"Nama: {Name}, Energi: {Energy} \n");
    }

    public void Attack(Wizard wizardLawanObj)
    {
        //mengurangi energi wizardLawanObj sebesar damage
        wizardLawanObj.Energy -= Damage;
        Console.WriteLine($"{Name} menyerang {wizardLawanObj.Name}");
        Console.WriteLine($"{Name} menyerang {wizardLawanObj.Name} adalah {wizardLawanObj.Energy}\n");
    }
}


