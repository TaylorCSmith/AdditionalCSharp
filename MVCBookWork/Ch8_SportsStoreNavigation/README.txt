CHAPTER SUMMARY (FROM BOOK)

In this chapter, I built most of the core infrastructure for the SportsStore application. It does not have many features that you could demonstrate to a client at this point, but behind the scenes, there are the beginnings of a domain model with a product repository backed by SQL Server and the Entity Framework. There is a single controller, ProductController, that can produce paginated lists of products, and I have set up DI and defined a clean and friendly URL scheme. 

If this chapter felt like a lot of setup for little benefit, then the next chapter will balance the equation. Now that the fundamental structure is in place, we can forge ahead and add all of the customer-facing features: navigation by category, a shopping cart, and a checkout process.