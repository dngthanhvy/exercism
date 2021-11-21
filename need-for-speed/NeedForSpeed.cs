using System;

class RemoteControlCar {
    private int speed;
    private int distanceDriven = 0;
    private int battery = 100;
    private int batteryDrain;
    public RemoteControlCar(int speed, int batteryDrain) {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained() {
        return this.battery == 0 || this.battery < this.batteryDrain ? true : false;
    }

    public int DistanceDriven() {
        return this.distanceDriven;
    }

    public void Drive()
    {
        if (!this.BatteryDrained()) {
            this.distanceDriven += this.speed;
            this.battery -= this.batteryDrain;
        }
    }

    public static RemoteControlCar Nitro() {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    private int distance;

    public RaceTrack(int distance) {
        this.distance = distance;
    }

    public bool CarCanFinish(RemoteControlCar car)
    {
        while (!car.BatteryDrained()) {
            car.Drive();
            if (car.DistanceDriven() >= this.distance) {
                return true;
            }
        }

        return false;
    }
}
