# String Calculator exercise

This exercise is a simple programming exercise to demo the differency between using git `merge` only and using git `merge`+`rebase`.

### Prepare

1. Create teams of 3 people.
2. The youngest from team forks this repository on github.
3. Everyone clones the forked repository.

### Code and commit

4. The task is to make all tests from `Program.Main()` pass.
   * To run the tests just run the application
   * Each test writes `OK` when it passes and `Test did not pass. Expected...` otherwise
   * `StringCalculator` class is supposed to sum numbers passes in a string, ex. `"1,2,3"` should return `6`
   * `Generator` class is supposed to generate inputs for `StringCalculator`
   * 2 people work on the `StringCalculator`
      * 1 person works on the validating input - `StringCalculator.Validate()`
      * 1 person works on the suming numbers - `StringCalculator.Sum()`
   * 1 person works on the `Generator`
   * Everyone works and commits to his/her own branch
5. When coding remember to commit frequenty. You can commit after implementing every unit test.

### Putting it all together

When you are done coding and commiting it's time to put everything together.

#### Merge only

6. Try the `merge` only apporach with your team first:
    * Everyone just merges his work into `master` and pushes it to `origin`

How does the commit history look like?
Is it clear and easy to follow?

#### Reseting repositories

We need to reset all repositories so we can try the git `rebase`+`merge` approach.

7. Reset `master` in `origin` to the commit it was on before everyone merged his changes.
    You can do it using the following commands:
```
git checkout master
git reset --hard <hash of commit master should be reset to>
git push --force
```
This will reset `master` both locally and in `origin` to the commit speified commit.

The remaining 2 team members will need to wait untill you are done and then:
```
git checkout master
git fetch
git reset --hard origin/master
```
This will fetch the state in which `master` is in `origin` and then `reset` the local `master` to the same commit.

#### Rebase and merge

Try the `rebase` + `merge` apprach with your team.
Now before `merging` we need to make sure our commits are on top of the lastest `master` branch.
To do this we need to:
```
git checkout master
git pull
git checkout your_branch_name
git rebase master
git checkout master
git merge your_branch_name
git push
```
The most important part here is `git rebase master`. This command will take all commit from your current branch, which are not yet in `master`, and re-commit them on top of the current `master`.

How does the git commit history now look like now?
Is it clerer than it was using the `merge` only apprach?