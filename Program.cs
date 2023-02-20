using yield_test;

var _base = new NewOverride();
var one = new DeliveredOne();
var two = new DeliveredTwo();

NewOverride _one = new DeliveredOne();

_base.Say();
one.Say();
two.Say();
