# Method-Hiding-Demo
/* Mohd Anwar jamal Faiz <br />
 * Toughjamy@yahoo.com <br />
*/

This repository intends to demonstrate and exploit Method hiding functionality


In here, I tried to show a new feature in C# or Visual studio languages. This is not in Java, and I have proactively tested that ;) <br/>

Example: Class A has a Print method; class B inherits from class A and implements the Print method as well. Now Print method will be overridded. Simple!
But now, test carefully that what happens if you change the Print method signature in class B. If you add the new keyword there, a behavior changes.
In this case the method does not overrides. In fact it will hide the method.
<br> Most Important: In normal object calls, this one will not be caught. The behavior difference is seen when you make an object with parent class variable.

Look the complete Blog post : http://www.w3lc.com/2017/05/method-hiding-vs-overriding-in-c-new.html

<br><br>



The result of the run is as follows: <br /> <br />
Demo of overriding...

 a.Getname : A

 b.Getname : B

 a2.Getname : A2

 b2.Getname : B2


Demo of method hiding...

 x.Getname : A

 y.Getname : A2
 
 
<br /><br />
This repository is to assist the blog post and many others coming in the future. <br /><br />

regards world!<br />
@Majf<br />
http://www.w3lc.com<br />

