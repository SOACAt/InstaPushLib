# InstaPushLib
[InstaPush API](https://instapush.im/developer/rest) C# implementation.

## Examples

```c#
// Apps - List
var apps = new SOACat.InstaPushLib.Apps("https://api.instapush.im/v1/", "[User token]");
var list = apps.ListAsync();
apps.Wait();
...

```

```c#
// Apps - Add
var apps = new SOACat.InstaPushLib.Apps("https://api.instapush.im/v1/", "[User token]");
var add = apps.AddAsync(new AppAddRequest() { title = "TestExample" });
add.Wait();
...

```

```c#
// Events - List
var list= new SOACat.InstaPushLib.Events("https://api.instapush.im/v1/", "[Api Key]", "[Api Secret]");
var res=list.ListAsync();
res.Wait();

foreach(SOACat.InstaPushLib.dto.ResponseEvent r in res.Result){
   Console.WriteLine(r.title);
}
...

```

```c#
// Events - Add
var add= new SOACat.InstaPushLib.Events("https://api.instapush.im/v1/", "[Api Key]", "[Api Secret]");
var res=add.AddAsync(new SOACat.InstaPushLib.dto.EventAddRequest(){ 
                title="Register", 
                trackers=new string[]{"email","name"}, 
                message="{email} registered with name {name}."});
res.Wait();

Console.WriteLine(res.Result.msg);

...

```

```c#
// Notifications - Send
var noti = new SOACat.InstaPushLib.Notifications("https://api.instapush.im/v1/", "[Api Key]", "[Api Secret]");
var track = new Dictionary<string, string>();
track.Add("email", "a@a.com");
track.Add("name", "Aston Martin");
var res = noti.SendAsync(new NotificactionRequest() { @event = "Register", trackers = track });
res.Wait();
Console.WriteLine(res.Result.msg);

...

```


[See More](https://instapush.im/)
