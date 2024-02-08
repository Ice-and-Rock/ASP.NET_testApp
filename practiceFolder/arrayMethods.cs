@page
@model IndexModel

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