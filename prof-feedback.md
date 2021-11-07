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
    <title>Po\/lished+</title>
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


## Week 3 ----------------------

Code Quality: 2/3
Design: .75/1
File Organization & Commits: 1/1
Total: 3.75/5

- Background image URL paths are incorrect. Currently `./image/banners/soccer-banner-bw.jpg` but should be `../image/banners/soccer-banner-bw.jpg`. The `../` will go up out of the `css` folder before then going into the `image` folder.
- Typo in `.btn` ruleset: `border: .125rem soild #09a38c;` should be `border: .125rem solid #09a38c;`
- Button in CTA banner should be white
- "Join now..." banner should be in its own `<section>`
- You should avoid writing in all caps in HTML as it is bad for accessibility and SEO. Instead, you should write in normal sentence case and use `text-transform: uppercase;` to make the text appear all caps.
- Your `<a>` tags all have `href` pointing to pages like `first.html` or `second.html`. For now you should just put a placeholder `#`. In the future we will be making more pages but they will have more descriptive names such as `sign-up.html`.

## Week 4 ----------------------

Code Quality: 1.5/3
Design: .75/1
File Organization & Commits: 1/1
Total: /5

- Make sure to review your CSS to insure it is neat and organized, including:
  - remove empty lines inside of CSS rules
  - there should be a space between the selector and the opening curly bracket `{`
  - there should be a space between each ruleset
  - double check indentation
- You should be using the colours and font (Ubuntu) provided in the exercise assets repo.
- `h5` should have a `border-bottom`
- `h1` and `h2` should have a normal font weight, not bold
- You should apply your default type styles directly to the tag selectors `h1` instead of classes as they are applied generally across the website.
- The CSS should all be done in the `css/main.css` file. That way the styles will apply to all of your pages
- Make sure to include the default `margin` reset code we worked on together in class!
- You should use the `type-scale.com` site to help generate your typescale
- For the `stylesheet.html` file, you do not need to put each heading into separate `<section>` and `<div>` tags. Some thing simple like whats below is enough.
  - The styling should be directly applied to the heading tags, not to a `div` around it

```html
<!DOCTYPE html>
<html lang="en-ca">
<head>
  <meta charset="utf-8">
  <title>Polished+</title>
  <meta name="handheldfriendly" content="true">
  <meta name="mobileoptimized" content="240">
  <meta name="viewport" content="width=device-width,initial-scale=1">
  <link href="css/main.css" rel="stylesheet">
  <link href="https://fonts.googleapis.com/css?family=Ubuntu:400,400i,700" rel="stylesheet">
</head>
<body>

  <div class="container-text">

    <h1>Heading 1</h1>
    <h2>Heading 2</h2>
    <h3>Heading 3</h3>
    <h4>Heading 4</h4>
    <h5>Heading 5</h5>
    <h6>Heading 6</h6>
    <p>Lorem ipsum dolor sit <a href="#">amet consectetur</a> adipisicing elit. In blanditiis a dolor quasi illo eius pariatur saepe quibusdam quisquam mollitia libero amet neque velit nisi aspernatur, tempora eos. Modi, odio?</p>

  </div>

</body>
</html>
```

## Week 5 ----------------------

Code Quality: 1/3
Design: .5/1
File Organization & Commits: 1/1
Total: 2.5/5

Part 1 is incomplete.

- make sure you are applying the correct colours from the assets repository.

Part 2: 
- the Ubuntu font should be applied to your website


## Week 6 ----------------------

Code Quality: 0/3
Design: 0/1
File Organization & Commits: 1/1
Total: 1/5

Part 1: Incomplete

Part 2: Incomplete

## Week 7 ----------------------

Code Quality: 1.5/3
Design: .5/1
File Organization & Commits: 1/1
Total: 3/5

- Don't forget to update the link in the Platform Tour nav item to link to the Platform Tour page! The logo should also link back to the home page.
- There are inconsistencies in the look of your navbar on the two pages. They should look identical. Copy and pasting the original code will make this easier.
- You are missing the `<link>` tag for your Google Font
- On the Platform Tour page, remove the `h1` from the navbar and make the "Next Level Design at Your Fingertips." heading the `h1`. You need to have a unique `h1` on every page.
- "The Polished+ Platform" heading should be `h2` and each platform item heading should be `h3`
- On your containers, use a max-width of a hard value, like `70em` instead of a percentage. This will use the space a bit better and will keep things from getting too large.
- You should have two equal sized columns at the large screen size. You have a 1/3 and 2/3 sized columns that do not match the screenshot. You then limited the width of the content inside which is miss-aligning things.


## Week 9 ----------------------

Code Quality: 2.25/3
Design: .5/1
File Organization & Commits: 1/1
Total: 3.75/5

- Your HTML files should be appropriately named for the content of the page. In this case, it should be named `pricing.html`. Your file names should also be all lowercase letters.
- Remove the `h2` around the logo in the header as it is not an appropriate heading here. A `strong` tag is a good alternate.
- Your `caption` is empty. It should be removed.
- Avoid creating numbered classes like `.tr1`. These are not descriptive enough to describe their purpose. Also, the amount of content and rows could change, which will make the classes unusable.
- The Premium column should be highlighted with a different text, button, and background color!
- Use a container! The table should be contained.