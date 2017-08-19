# InstaPushLib

Examples

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



