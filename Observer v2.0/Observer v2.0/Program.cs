using Observer_v2._0;

class Program {
    static void Main(string[] args) { 
        Device device = new Device();
        Device device2 = new Device();
        MeteoStanice meteo = new MeteoStanice();

        meteo.Registruj(device);
        meteo.Registruj(device2);

        meteo.Notifikuj(200000000);
    }
}