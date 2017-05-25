# FilterSpam-Machine-learning

filter spam for detecting spam email<br />
ML algorithm used is NaiveBayes<br />
## Code Example

  NaiveBayes.NaiveBayes naiveBayes = new NaiveBayes.NaiveBayes();<br />
            // spam mail<br />
            var result = naiveBayes.CheckEmail("Buy Cheap cialis Online");<br />
            Assert.AreEqual(true, result);<br />
            Console.WriteLine(result.ToString());<br />
            // not spam mail<br />
            result = naiveBayes.CheckEmail("Thanks in advance for your support");<br />
            Assert.AreEqual(false, result);<br />
            Console.WriteLine(result.ToString());<br />


## Installation

download the vs solution and run it from vs editor
