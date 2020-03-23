namespace HaloKit{
public class HaloButtonEventArgs: EventArgs{
public HaloNode instance;

public dynamic data;

public HaloButtonEventArgs(HaloNode instance, dynamic data){
this.instance = instance;
this.data = data;

}

}
public class HaloNode{
public HaloNode parent;
public Array<HaloNode> children;

public event EventHandler<HaloButtonEventArgs> OnButton;

private void signalButton(HaloButtonEventArgs args){OnButton(this,args)}
}

}