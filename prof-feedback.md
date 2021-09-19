# Professor Feedback

## Week 2B ----------------------

This is a tough exercise to start with. There are a fair amount of updates needed to make sure you're good to go for the next set of exercises:

- home page file should be `index.html`
- You are missing the <head> tag which should contain important meta data
- All visual content should be inside of the <body>
- <form> and <input> should not be used. All the Sign Up links should be an <a>. We will use styling to make it look like a button
- You <div class="main"> should be a <main>, which is the more appropriate semantic tag
- <figure> tags are only necessary when there is a visual caption. No <figure> tags are needed on this page
- <b> tags should not be used for headings. Use the appropriate heading tag. All major headings should be <h2> on the home page.
- You have the incorrect content in the first banner of the main. The heading should be "Community Feel. Professional Look." Make sure you have copied in the correct content from the content files.
- the <h1> should be wrapped around the <img> inside the <header>, the "Community feel" heading should be an <h2>
- <img> tags should all have a `src` and an `alt` attribute. Like this: <img src="./images/photo-1.jpg" alt="A photo of a nice dog">. `srcset` is the incorrect attribute to use in this case
- logo bar images should also be in an <ul> with <li> tags
- the logo bar, the "Design your brand..." content, and the "Join now..." banner should be in three separate <section> tags
- You should use a project file path for your images. See my example above. You have created a file path that references the exact location based on your computer, which will not work once this code is online or shared with me
- The white logo should be in the footer
- The logos in the header/footer should be wrapped in an <a> linking to the home page
- the <li> tags in the <footer> should be in an <ul>
- <p>©2021 Algonquin College</p> ==> <small>&copy; 2021 Algonquin College</small>
- the extra date and link to your email is not necessary in the footer, please remove


Here is how the base HTML set up should look:

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Polished+</title>
</head>
<body>
    <header>
        <!-- nav content -->
    </header>
    <main>
        <!-- page content -->
    </main>
    <footer>
        <!-- outro content -->
    </footer>
</body>
</html>