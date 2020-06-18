# Single Responsibility Principle

### What is the Single Responsibility Principle in C#?

`The Single Responsibility Principle states that “Each software module or class should have only one reason to change“. In other words, we can say that each module or class should have only one responsibility to do.
So we need to design the software in such a way that everything in a class or module should be related to a single responsibility. That does not mean your class should contain only one method or property, you can have multiple members (methods or properties) as long as they are related to a single responsibility or functionality.
So, with the help of SRP, the classes become smaller and cleaner and thus easier to maintain.`

### How can we achieve the Single Responsibility Principle in C#?
`Let us understand the need for the Single Responsibility Principle in C# with an example. Suppose we need to design an Invoice class. As we know an Invoice class basically used to calculate various amounts based on its data. The Invoice class does not know how to retrieve the data, or how to format the data for display, print, logging, or sending an email, etc. 
If we write the database logic, business logic as well as the display logic in a single class, then our class performing multiple responsibilities. Then it becomes very difficult to change one responsibility without breaking the other responsibilities. So, by mixing multiple responsibilities into a single class, we are getting the following disadvantage,`

<ol style="text-align: justify;">
<li><strong><span style="font-family: arial, helvetica, sans-serif; color: #000000;">Difficult to understand</span></strong></li>
<li><strong><span style="font-family: arial, helvetica, sans-serif; color: #000000;">Difficult to test</span></strong></li>
<li><strong><span style="font-family: arial, helvetica, sans-serif; color: #000000;">Chance of duplicating the logic of other parts of the application</span></strong></li>
</ol>

### The benefits of SRP include:
<ol style="text-align: justify;">
  <li><strong><span style="font-family: arial, helvetica, sans-serif; color: #000000;">Reduction in complexity of code</span></strong></li>
<li><strong><span style="font-family: arial, helvetica, sans-serif; color: #000000;">Increased readability, extensibility and maintenance</span></strong></li>
<li><strong><span style="font-family: arial, helvetica, sans-serif; color: #000000;">Reusability and reduced errors</span></strong></li>
  <li><strong><span style="font-family: arial, helvetica, sans-serif; color: #000000;">Better testability</span></strong></li>
  <li><strong><span style="font-family: arial, helvetica, sans-serif; color: #000000;">Reduced coupling</span></strong></li>
</ol>

### Example of without the Single Responsibility Principle:

<p style="text-align: justify;"><span style="color: #000000; font-family: arial, helvetica, sans-serif;">Please have a look at the following diagram that we want to implement in the following example.</span></p>
<img class="wp-image-3201 alignnone" title="Voilatiing Single Responsibility Principle in C#" src="https://dotnettutorials.net/wp-content/uploads/2018/06/Voilatiing-Single-Responsibility-Principle.png" alt="Voilatiing Single Responsibility Principle in C#" width="656" height="251" srcset="https://dotnettutorials.net/wp-content/uploads/2018/06/Voilatiing-Single-Responsibility-Principle.png 823w, https://dotnettutorials.net/wp-content/uploads/2018/06/Voilatiing-Single-Responsibility-Principle-300x115.png 300w, https://dotnettutorials.net/wp-content/uploads/2018/06/Voilatiing-Single-Responsibility-Principle-768x294.png 768w" sizes="(max-width: 656px) 100vw, 656px">

### Implementing the Single Responsibility Principle in C#

`Please have a look at the following diagram. `

<img class="wp-image-3202 alignnone" title="Single Responsibility Principle in C#" src="https://dotnettutorials.net/wp-content/uploads/2018/06/Single-Responsibility-Principle-in-C.png" alt="Single Responsibility Principle in C#" width="687" height="219" srcset="https://dotnettutorials.net/wp-content/uploads/2018/06/Single-Responsibility-Principle-in-C.png 931w, https://dotnettutorials.net/wp-content/uploads/2018/06/Single-Responsibility-Principle-in-C-300x95.png 300w, https://dotnettutorials.net/wp-content/uploads/2018/06/Single-Responsibility-Principle-in-C-768x244.png 768w" sizes="(max-width: 687px) 100vw, 687px">
