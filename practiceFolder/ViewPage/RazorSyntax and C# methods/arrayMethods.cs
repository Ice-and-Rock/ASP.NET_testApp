@page
@model IndexModel

// Create a new Variable
@{ 
int myNumber = 33;
string myName = "Nick"
}

// Switch Statements
@{ string grade = "A"; }
<div class="text-center">
  <h1 class="display-5">Let's work with conditionals!</h1>
  <hr>

  <h3>Exam results:</h3>
  <br>
  <!--   Switch statement below -->
  @switch (grade) {
    case "A": <h4>Excellent job!</h4>
    break;
    case "B": <h4>Well done!</h4>
    break;
    case "C": <h4>Needs some work!</h4>
    break;
    case "D": <h4>“You passed”</h4>
    break;
    case "E": <h4>Excellent job!</h4>
    break;
    case "F": <h4>You failed, better try next time</h4>
    break;
    default: <h4>Invalid grade!</h4>;
    break;
  }
  <h4>Your grade is, @grade</h4>
</div>


// Array methods -> LOOPS
<!-- Create favoriteFoods below -->
@{
List<string> favoriteFoods = new List<string>()
  {
    "Lasagne",
    "Beans",
    "Toast",
    "More beans"
  };
}

<div class="text-center">
  <h1 class="display-5">Let's work with loops!</h1>
  <br>

  <h4>Results from your for loop:</h4>
  <ul>
    @for (int i = 0; i < favoriteFoods.Count; i++)
    {
      <li>@favoriteFoods[i]</li>
    }
  </ul>

  <br>

  <h4>Results from your foreach loop:</h4>
  <ul>
    @foreach(string food in favoriteFoods)
    {
      <li>@food</li>
    }
  </ul>

  <br>
  <h4>Results from your while loop:</h4>
  <ul>
    @{ int counter = 0;}
    @while(counter < favoriteFoods.Count)
    {
      <li>@favoriteFoods[counter++]</li>
    }
  </ul>
  
</div>