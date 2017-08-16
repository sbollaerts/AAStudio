namespace AAStudio
{
    public delegate void NotifyHandler(object sender, OnNotifyEventArgs e);
    public delegate void SpriteSelectedHandler(object sender, OnSpriteSelectedEventArgs e);
    public delegate void DataChangedHandler(object sender, OnDataChangedEventArgs e);
    public delegate void MouseMovedHandler(object sender, OnMouseMoveEventArgs e);
    public delegate void PictureChangedHandler(object sender, OnPictureChangeEventArgs e);
}