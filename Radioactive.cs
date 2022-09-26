public class Radioactive : ItemMap {

    public Radioactive() : base("!! ") {}

    public void Discharge(Robot r) 
    {
        r.energy = r.energy-3;
    }
    public void OnDischarge(Robot r) 
    {
        r.energy = r.energy-10;
    }

}