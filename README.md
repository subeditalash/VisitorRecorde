It’s easy to create a Windows form in C#. All you need to do is use the
Windows Application Wizard, and you have a form. Then you just add controls
by dragging them onto the form and manipulating their properties and events.
After you place the controls on the form, you can modify the controls using
their properties and events at runtime. Many colleges and universities have a
C++ programming course. Some take advantage of the Integrated
Development Environment (IDE) provided by Visual C++ (or Visual Studio) to
teach students Windows form application programming. They frequently focus
the teaching on how to use IDE to build the application with minimum or no
hand coding involved. However, students need hand-coding experience to
truly understand the structure of Windows-based applications. In this paper,
the author advocates the necessity to teach Windows form application
programming with hand coding, without the use of IDE

Feature of System / User Manual
1. Login Screen

There is login page which check the username and password of the admin. With
this form you are only allowed to get access to the application. If the user enter
it will throw the error message . user also can exit through pressing the exit
button.

2. HomePage
Figure 2 home page
After giving the correct username and password. You get access to the home
page. From home we can entre any form we required. And the datagridview
show the all the information of the ticket system. And there is simple notice as
lable in home page about the weekend day and the group of people that group
of people must come out at the same time. All this information on ticket system
is recorded in a separate CSV file.

3. Individual Form

In this form we enter the data of the individual customer where individual id is
the primary key and the entry time is get through the datetime picker thought it
always show the current time. Type take the information whether the customer
is adult or child and day take the information on the date of the day and the add
button add the value to the individual customer list.
4. Group Form

This form take the data of the customer who have visti on the group in this
form groupId is its primary key and entry time get the time of the form open on
24hr basis and adult store the number of the adult visit and child store the
number of child visti in the group and if the number is less than the 5 then the
error message is shown. Day store the data of the date of the form open.
5. ExitForm
In this form we have to enter the id and choose whether to input the indivudal
id or group id. Then press the search button.
Figure 7 exit form after group
If the admin select the group the it will compare the group id and show the
respective data. Data show the duration weekday payment and all the data
save in id.
exit from after individual
If admin select the individual and give the individual id it give the respective
data like duration weekday payment and data store in the id. The you can exit
through exit data.
Weekly report 
It shows the weekly data in datagridview where there is value of weekday and
number of customer and duration minutes and cost and there is button to sort
the data.

Daily Report

In this report we can see the daily report where there is weekday and total
number of customer and total duration and cost of that day.
CS6004NP Application Development

Chart

In this chart we have show the weekly data in chart where there is information
on the customer on the basis of the duration, cost and days.
