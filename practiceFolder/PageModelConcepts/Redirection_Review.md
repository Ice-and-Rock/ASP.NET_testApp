# REDIRECTION

### Review

You’re on your way to becoming an ASP.NET master! In this lesson we learned some methods and types that are used to redirect users to pages:

When a handler method has no return statement, it will send the associated page as a response.
When a redirect method is used in a handler method, it must return the type IActionResult (or some type that implements the interface) or Task<IActionResult> if asynchronous.
Page() causes the server to render the Razor view page associated with the current page model.
RedirectToPage() causes the server to render the Razor view page described in the method argument. Generates a 302 HTTP status code.
NotFound() causes the server to send a “Status 404 Not Found” response.
These are just a few common redirection methods. You can find a full list of them defined within the PageModel type. A good one to start with is Redirect(), which works similarly to RedirectToPage(), but can redirect to URLs outside of your own application.

You can find further examples of redirection methods in the Microsoft tutorials and a nice list of common redirection methods on Learn Razor Pages.