SUMMARY FROM BOOK:
In this chapter, I have given you an overview of the Razor view engine and how it can be used to generate HTML. I showed you how to refer to data passed from the controller via the view model object and the view bag, and how Razor expressions can be used to tailor responses to the user based on data values. You will see many different examples of how Razor can be used in the rest of the book and I describe how the MVC view mechanism works in detail in Chapter 20. In the next chapter, I describe the essential development and testing tools that underpin the MVC Framework and that help you to get the best from your projects.

IMPORTANT CONCEPT: 

Action Method 
  - Does: Pass view model object to the view
  - Doesn't: Pass formatted data to the view

View
  - Does: Use the view model object to present content to the user
  - Doesn't: Change any aspect of the view model object

Important to differentiate between processing data and formatting data... 
Views format data... which is why an object is passed to the iew rather than formatting the objects properties into a display string... 
Processing data includes selecting the data objects to display... is the responsibility of the controller 