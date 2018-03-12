# Calculator
This is my calculator project. It's a simple project to learn, create, and explore.

The calculator's current state is a simple one. Add, Subtract, Divide, and Multiplication are all functioning if your input is any number.

UPDATE 0.0.2:
 - Included a new Clear button to empty all collection containers, and clear all output labels. <br>
 - Included multi-input calculations of numbers greater than 1 input. <br>
 - Fixed some code duplication and created a new method for number dequeueing.<br>
 - Made Calculator output label write from a fixed length, instead of auto-resizing.<br>
 - Fixed division error.<br>
 - Fixed subtraction error.<br>
 - Fixed unnecessary stack push call.<br>
 
Upcoming Changes 0.0.3:
 - Look for single delegate to clean up some of the programs clutter.
 - More functionality for college students (Notepad, Calculator, To do list, Calendar) all in one place.
 - Optimizations once code is a bit further along.
 - Look for new functions like sqrt(), log(), sin(), tan(), and cos().
 - and many more!
 
 ![calc-home](https://user-images.githubusercontent.com/20911133/37311317-68cd38b6-260c-11e8-946c-cfaf60f65f9e.PNG)
 
 
![calc-input](https://user-images.githubusercontent.com/20911133/37311364-91ff7078-260c-11e8-90c4-da9aa4043bbf.PNG)

![calc-equals](https://user-images.githubusercontent.com/20911133/37311374-999f25b2-260c-11e8-8e6b-aed017ce2fbf.PNG)
 
<br>
Errors:
Logic: Multi-valued inputs are being seen as a single input value. Instead of 12 being a single value it is currently 1, 2. (urgent)
<br>
(FIXED){
  Visual: Output label is currently expanding in the wrong direction, and shouldn't be expanding all together. (not urgent)
}
