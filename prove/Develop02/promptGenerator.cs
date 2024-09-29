using System;

public class promptGenerator{
    public List<string> prompts = new List<string>();

    // set up prompt
    public promptGenerator(){
        prompts.Add("What was the best part of your day?");
        prompts.Add("What was a kind thing you did today?");
        prompts.Add("Who was someone that made your day?");
        prompts.Add("What is something you learned today?");
        prompts.Add("What would've made your day better?");
    }

    public string GetRamdomString(){
        Random randomPrompt = new Random();
        int indexPrompt = randomPrompt.Next(prompts.Count);
        return prompts[indexPrompt];
    }
}