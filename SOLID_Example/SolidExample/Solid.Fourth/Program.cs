// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/* Interface Segregation Principle - принцип разделения интерфейсов. Данный принцип обозначает, 
 что не нужно заставлять клиента (класс) реализовывать интерфейс, который не имеет к нему отношения.

Интерфейс IMoving имеет несколько методов: CarMoving(передвижение на машине), BusMoving(передвижение на автобусе),
TramMoving(передвижение на трамвае). Реализация этого интерфейса будет подразумевать реализацию всех методов,
но мы не можем быть уверены, что в каждом случае мы сможем это сделать по логике, что противоречит четвертому
принципу SOLID.

Необходимо разделить интерфейс IMoving на несколько и в конекретных реализациях наследоваться от необходимых интерфейсов.
 */
