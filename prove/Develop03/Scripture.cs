using System;
using System.ComponentModel;
using System.Dynamic;

public class Scripture{
    // Scripture member variables
    private Reference _reference;

    private List<Word> words = new List<Word>();

    public Scripture(Reference reference, string text){
        List<string> temporaryWord = text.Split(' ').ToList();
        foreach (string word in temporaryWord){
            Word memorizeScripture = new Word(word);
            memorizeScripture.Show();
            words.Add(memorizeScripture);            
        }
        _reference = reference;
    }
    public void HideRandomWords(int numberToHide){
        for (int i = 0; i < numberToHide; i++){
            Random hidingIndex = new Random();
            int index = hidingIndex.Next(words.Count);
            if (words[index].isHidden() && !IsCompletelyHidden()){
                --i;
                continue;
            }
            else if (IsCompletelyHidden()){
                break;
            }
            words[index].Hide();
        }
    }
    public string GetDisplayText(){
        string fullText = "";
        foreach (Word word in words){
            fullText += word.GetDisplayText() + " ";
        }
        return fullText;
    }
    public bool IsCompletelyHidden(){
        foreach (Word word in words){
            if (word.isHidden() == false){
                return false;
            }
        }
        return true;
    }
}