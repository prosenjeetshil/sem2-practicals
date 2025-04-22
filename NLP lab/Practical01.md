# Practical No: 01

## Write a program to implement Tokenization of text


```python
print("125 Prosenjeet Shil")
```

    125 Prosenjeet Shil
    


```python
import nltk
nltk.download('punkt_tab')
```

    [nltk_data] Downloading package punkt_tab to
    [nltk_data]     C:\Users\prose\AppData\Roaming\nltk_data...
    [nltk_data]   Package punkt_tab is already up-to-date!
    




    True




```python
import nltk
data="Welcome to SIMS!!"
tokens=nltk.sent_tokenize(data)
print(tokens)
```

    ['Welcome to SIMS!', '!']
    


```python
tokens=nltk.word_tokenize(data)
print(tokens)
```

    ['Welcome', 'to', 'SIMS', '!', '!']
    
