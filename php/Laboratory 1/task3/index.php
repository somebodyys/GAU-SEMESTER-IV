<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Easy Physics</title>
    <link rel="stylesheet" href="style.css">
</head>

<body>
    <h1>Exam In Physics</h1>
    <div class="wrap">
        <form method="POST">
            <div class="task">
                <span>1. Very simply, what’s the difference between weight and mass?</span>
                <br><br>
                <input type="hidden" name="question1" value="0">
                <input type="radio" name="question1" value="1">
                <label for="1">No difference – they’re synonyms</label><br>
                <input type="radio" name="question1" value="2">
                <label for="2">Mass is the amount of matter in an object, weight is the gravitational force on an object</label><br>
                <input type="radio" name="question1" value="3">
                <label for="3">Mass is metric, weight is imperial</label> <br>
                <input type="radio" name="question1" value="4">
                <label for="4">Mass is a measure of size, weight is a measure of density</label>
            </div>

            <div class="task">
                <span>2. The laws of physics tell us that energy is:</span>
                <br><br>
                <input type="hidden" name="question2" value="0">
                <input type="radio" name="question2" value="1">
                <label for="1">Conserved</label><br>
                <input type="radio" name="question2" value="2">
                <label for="2">Concerned</label><br>
                <input type="radio" name="question2" value="3">
                <label for="3">Constant</label> <br>
                <input type="radio" name="question2" value="4">
                <label for="4">Contained</label>
            </div>

            <div class="task">
                <span>3. Which of these phenomena inspired Albert Einstein in his development of general relativity?</span>
                <br><br>
                <input type="hidden" name="question3" value="0">
                <input type="radio" name="question3" value="1">
                <label for="1">Seeing an apple drop from tree</label><br>
                <input type="radio" name="question3" value="2">
                <label for="2">Watching two trains move in opposite directions</label><br>
                <input type="radio" name="question3" value="3">
                <label for="3">The vibration of strings on a violin</label> <br>
                <input type="radio" name="question3" value="4">
                <label for="4">Seeing a man fall off a roof</label>
            </div>

            <div class="task">
                <span>4. When you map out the universe from the smallest scale (the Planck length, which is 1.6×10−35 metres) to the largest (the observable universe, which is 91 billion light years across), what do you find approximately in the middle?</span>
                <br><br>
                <textarea name="question4" cols="100" rows="5" placeholder="Answer here..."></textarea>
                <?php
                if (isset($_POST['sub'])) {
                ?>

                    <h4>* Right Answer : Our solar system</h4>

                <?php
                }
                ?>
            </div>


            <div class="task">
                <span>5. The largest known star in the galaxy is UY Scuti, in the Scutum Constellation. If it was plopped into the centre of our solar system, where our Sun is now, how much space would it take up?</span>
                <br><br>
                <textarea name="question5" cols="100" rows="5" placeholder="Answer here..."></textarea>
                <?php
                if (isset($_POST['sub'])) {
                ?>

                    <h4>* Right Answer : Its outer edge would be beyond the orbit of Jupiter - basically half the size of our whole solar system</h4>

                <?php
                }
                ?>
            </div>


            <button type="submit" name="sub">Submit</button>
        </form>

        <?php
        $answers = array("2", "1", "2", "Our solar system", "Its outer edge would be beyond the orbit of Jupiter - basically half the size of our whole solar system");
        if (isset($_POST['sub'])) {

            $right_count = 0;
            $check = "question";
            for ($i = 0; $i <= sizeof($answers) - 1; $i++) {
                if ($answers[$i] == $_POST[$check . $i + 1]) {
                    $right_count++;
                }
            }
        ?>
            <div class="result">
                Final Score : <?= $right_count ?>/<?= sizeof($answers) ?>
            </div>
        <?php
        }
        ?>
    </div>

</body>

</html>