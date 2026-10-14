# Workflow

Every change goes in through a [pull request (PR)](glossary.md#pull-request-pr), even small ones. This is how professional teams work. ([GitHub flow](https://docs.github.com/en/get-started/using-github/github-flow))

## The loop

1. **Start from an up-to-date `main`.**
   ```sh
   git checkout main
   git pull
   ```
2. **Make a [branch](glossary.md#branch)** named for what you're doing.
   ```sh
   git checkout -b stage1-difficulty-levels
   ```
3. **Work and [commit](glossary.md#commit)** in small steps. Each commit message says what changed, in a few words. ([How to write a git commit message](https://cbea.ms/git-commit/))
4. **Push your branch.** The first push of a new branch needs `-u`:
   ```sh
   git push -u origin stage1-difficulty-levels
   ```
5. **Open a PR.** ([Creating a pull request](https://docs.github.com/en/pull-requests/how-tos/create-pull-requests/creating-a-pull-request))
   - Set **base repository** to *your* fork, not the one you forked from. GitHub picks the wrong one by default.
6. **Fill in the PR template.** Your reviewer reads it before the code, so make it worth reading. ([How to write the perfect pull request](https://github.blog/developer-skills/github/how-to-write-the-perfect-pull-request/))
7. **Request a review** from your reviewer. ([Requesting a review](https://docs.github.com/en/pull-requests/how-tos/create-pull-requests/requesting-a-pull-request-review))
8. **While you wait,** do the next step's Look up.
9. **Respond to feedback.** Push more commits to the same branch; the PR updates by itself. Reply to each comment, even if it's just "Done."
10. **Merge** once the PR is approved, then delete the branch.

## How big should a PR be?

Small. One step is often one PR. Split it if it's getting large. A PR that takes more than about 10 minutes to read is too big.

## Issues

An [issue](glossary.md#issue) is a to-do item on GitHub. Plan each feature in an issue before you build it. For steps, issues are optional.

Write `Closes #3` in the PR description, and merging the PR closes issue 3 for you. ([Linking a pull request to an issue](https://docs.github.com/en/issues/tracking-your-work-with-issues/using-issues/linking-a-pull-request-to-an-issue))

## Finishing a stage

When every box in the stage's "Done when" list is true, tag the commit on `main`:

```sh
git checkout main
git pull
git tag stage-1-done
git push origin stage-1-done
```

([Git tagging](https://git-scm.com/book/en/v2/Git-Basics-Tagging))

Later, you can compare two stages on GitHub to see everything that changed: `https://github.com/<you>/MathQuest/compare/stage-1-done...stage-2-done`. ([Comparing commits](https://docs.github.com/en/pull-requests/how-tos/commit-changes/comparing-commits))
