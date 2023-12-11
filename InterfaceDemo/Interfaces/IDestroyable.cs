namespace InterfaceDemo.Interfaces
{
    interface IDestroyable
    {
        string DestructionSound { get; set; }
        void Destroy();
    }
}