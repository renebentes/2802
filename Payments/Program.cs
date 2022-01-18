var room = new Room(3);
room.RoomSoldOutEvent += OnRoomSoldOut;

room.ReserveSeat();
room.ReserveSeat();
room.ReserveSeat();
room.ReserveSeat();
room.ReserveSeat();

static void OnRoomSoldOut(object? sender, EventArgs e)
{
    Console.WriteLine("Sala lotada");
}

class Room
{
    private int _seatsInUse;

    public Room(int seats)
    {
        Seats = seats;
        _seatsInUse = 0;
    }

    public int Seats { get; set; }

    public event EventHandler RoomSoldOutEvent;

    public void ReserveSeat()
    {
        _seatsInUse++;

        if (_seatsInUse > Seats)
        {
            OnRoomSoldOutEvent(EventArgs.Empty);
        }
        else
        {
            Console.WriteLine("Assento reservado");
        }
    }

    protected virtual void OnRoomSoldOutEvent(EventArgs e)
    {
        var handler = RoomSoldOutEvent;
        handler?.Invoke(this, e);
    }
}