# Getting API instance

## Getting Started
Build a submission form with a text field value that has an alias "yourName".  Then load your javascript console and run this code:
```
FrontendApiManager.onReady("submissionForm", function (api) {
    /**single line**/
    var textBox = api.getField("yourName");
   console.log(textBox.getValue());});
});
```

This code shows you how to add a table row (assuming the table field's alias is "table" and the fields are "firstName" and "lastName"

```
FrontendApiManager.onReady("submissionForm", function (api) {
    var table = api.getField("table");
    table.addRow([
        {
            alias: "firstName",
            value: "John"
        },
        {
            alias: "lastName",
            value: "Smith"
        }
    ]);
 });
 ```

## FrontendApiManager

`FrontendApiManager` is global scope variable which can be used to subscribe to `ready` event of specific form API.

- `onReady(apiName: string, handler: (apiInstance) => void)` - method for subscription.
  - `apiName: string` - supported values are `submissionForm`, `sessionForm` and `evaluationForm`. If current page doesn't contain specified form the handler will never be invoked.
  - `handler: (apiInstance) => void` - function to handle `ready` event. Receives instance of target API.

## Custom Javascript in Developer Settings

Custom script is already executed in handler of `ready` event described above, so there is no need to subscribe to event by your own. Form API instance is named `api`.

![image](https://user-images.githubusercontent.com/20421997/68542115-5ced5400-03db-11ea-9322-41d4d1c0e083.png)

# API reference

## Submission form and Session form:

- `getField(alias: string)` - returns api object for concrete field

## Evaluation form:

- `getQuestion(alias: string)` - returns api object for concrete question

## Fields API reference

### Single Line Text

- `getValue(): string` - returns current value.
- `setValue(value: string)` - sets new value.
- `show()` - makes field section visible if it was previosly hidden via frontend API.
- `hide()` - hides field section.
- `onChange(handler)` - event is triggered on focus out and value is changed.
- `offChange(handler)` - unsubscribe from change event.
- `autocomplete(options)` - attach autocomplete suggestions to input
  - `options`
    - `serviceUrl` - response format described here https://www.devbridge.com/sourcery/components/jquery-autocomplete/#jquery-autocomplete-response-format
    - `transformResult` - https://www.devbridge.com/sourcery/components/jquery-autocomplete/#jquery-autocomplete-non-standard-queryresults
    - `paramName` - default `query`. The name of the request parameter that contains the query.

### Mutliline Text

- `getValue(): string` - returns current value.
- `setValue(value: string)` - sets new value.
- `show()` - makes field section visible if it was previosly hidden via frontend API.
- `hide()` - hides field section.
- `onChange(handler)` - event is triggered on focus out and value is changed.
- `offChange(handler)` - unsubscribe from change event.

### Checkbox List

- `getValue(): string[]` - returns array of selected item ids.
- `setValue(listItemIds: string[])` - check items which are presented in array, uncheck if they are not in array.
- `show()` - makes field section visible if it was previosly hidden via frontend API.
- `hide()` - hides field section.
- `onChange(handler)` - event is triggered on check/uncheck of any checkbox.
- `offChange(handler)` - unsubscribe from change event.

### Radio List

- `getValue(): string` - returns selected item id or empty string if no item is selected.
- `setValue(listItemId: string)` - select item.
- `clearSelection()` - clears selection.
- `show()` - makes field section visible if it was previosly hidden via frontend API.
- `hide()` - hides field section.
- `onChange(handler)` - event is triggered when any item is selected or selection is cleared.
- `offChange(handler)` - unsubscribe from change event.

### Drop Down List

- `getValue(): string` - returns selected item id or empty string if no item is selected.
- `setValue(listItemId: string|null)` - select item. Pass `null` to clear selection.
- `show()` - makes field section visible if it was previosly hidden via frontend API.
- `hide()` - hides field section.
- `onChange(handler)` - event is triggered when any item is selected.
- `offChange(handler)` - unsubscribe from change event.

### Separator

- `show()` - makes field section visible if it was previosly hidden via frontend API.
- `hide()` - hides field section.

### Table

- `show()` - makes field section visible if it was previosly hidden via frontend API.
- `hide()` - hides field section. Also cancel row edit if exists.
- `addRow(rowValues): number` - add new row. Returns new row index.
  - `rowValues` - array of values. Value has the following schema:
    - `alias` - field alias
    - `value` - target field value
- `removeRow(rowIndex: number)` - removes row by index.
- `getRowCount(): number` - returns row count.

### Date

- `getValue(): Date` - returns [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) object of selected date.
- `setValue(value: Date)` - sets new date.
- `show()` - makes field section visible if it was previosly hidden via frontend API.
- `hide()` - hides field section.
- `onChange(handler)` - event is triggered when day is selected.
- `offChange(handler)` - unsubscribe from change event.

### Email

- `getValue(): string` - returns current value.
- `setValue(value: string)` - sets new value. Should be valid email.
- `show()` - makes field section visible if it was previosly hidden via frontend API.
- `hide()` - hides field section.
- `onChange(handler)` - event is triggered on focus out and value is changed.
- `offChange(handler)` - unsubscribe from change event.

### File Upload

- `getValue(): FileUploadValue` - returns current value.
  - `FileUploadValue`:
    - `mediaId: number` - optional
    - `caption: string` - optional
- `setValue(value: FileUploadValue): Promise` - sets new value. Returns [Promise](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Promise) which will be resolved if media id is valid and rejected if media id doesn't exist or access to media is forbidden for current user.
- `getUrl(): string` - returns url to uploaded file.
- `show()` - makes field section visible if it was previosly hidden via frontend API.
- `hide()` - hides field section.
- `uploadFile(file: File): Promise` - upload [File](https://developer.mozilla.org/en-US/docs/Web/API/File) to Filestack. Returns Promise which is resolved when upload is succeeded.
- `onChange(handler)` - event is triggered when file is uploaded or deleted.
- `offChange(handler)` - unsubscribe from change event.

### URL

- `getValue(): string` - returns current value.
- `setValue(value: string)` - sets new value. Should be valid uri.
- `show()` - makes field section visible if it was previosly hidden via frontend API.
- `hide()` - hides field section.
- `onChange(handler)` - event is triggered on focus out and value is changed.
- `offChange(handler)` - unsubscribe from change event.

### Address

- `getValue(): AddressFieldValue` - returns current value.
  - `AddressFieldValue`:
    - `street: string` - optional
    - `line2: string` - optional
    - `city: string` - optional
    - `countryCode: string` - optional
    - `state: string` - optional
    - `zip: string` - optional
- `setValue(value: AddressFieldValue)` - sets new value.
- `show()` - makes field section visible if it was previosly hidden via frontend API.
- `hide()` - hides field section.

### Application Name

- `getValue(): ApplicationNameFieldValue` - returns current value.
  - `AddressFieldValue` - `string` if one text field option is on, otherwise:
    - `firstValue: string` - optional
    - `secondValue: string` - optional
- `setValue(value: ApplicationNameFieldValue)` - sets new value.
- `show()` - makes field section visible if it was previosly hidden via frontend API.
- `hide()` - hides field section.
- `onChange(handler)` - supported only in one text field mode. event is triggered on focus out and value is changed.
- `offChange(handler)` - unsubscribe from change event.

### Application Category

- `getValue(): number[]` - returns array of category ids ordered by selected category path.
- `setValue(value: number[])` - array of category ids ordered by selected category path.
- `show()` - makes field section visible if it was previosly hidden via frontend API.
- `hide()` - hides field section.

### Letter of Recommendation

- `getValue(): LetterOfRecommendationFieldValue` - returns current value.
  - `LetterOfRecommendationFieldValue`
    - `fullName: string`
    - `email: string`
- `setValue(value: LetterOfRecommendationFieldValue | null)` - sets new value. Pass `null` to clear inputs. Can't be set if request is already sent.
- `show()` - makes field section visible if it was previosly hidden via frontend API.
- `hide()` - hides field section.

### Session name

- `getValue(): string` - returns current value.
- `setValue(value: string)` - sets new value.
- `show()` - makes field section visible if it was previosly hidden via frontend API.
- `hide()` - hides field section.
- `onChange(handler)` - event is triggered on focus out and value is changed.
- `offChange(handler)` - unsubscribe from change event.

## Evaluation Form Questions API reference

### 1-3, 1-5, 1-10 range

- `getValue(): number` - returns selected item value or undefined if no item is selected.
- `setValue(value: number)` - value is integer in range of current type question.
- `show()` - makes question section visible if it was previosly hidden via frontend API.
- `hide()` - hides question section.
- `onChange(handler)` - event is triggered when any item is selected.
- `offChange(handler)` - unsubscribe from change event.

### Numeric

- `getValue(): number` - returns current value.
- `setValue(value: number)` - sets new value.
- `show()` - makes question section visible if it was previosly hidden via frontend API.
- `hide()` - hides question section.
- `onChange(handler)` - event is triggered on focus out and value is changed.
- `offChange(handler)` - unsubscribe from change event.

### List

- `getValue(): string` - returns current selection text.
- `setValue(value: string)` - sets new value. `value` is list item text (case-insensitive).
- `show()` - makes question section visible if it was previosly hidden via frontend API.
- `hide()` - hides question section.
- `onChange(handler)` - event is triggered when any item is selected.
- `offChange(handler)` - unsubscribe from change event.

### Free Text

- `getValue(): string` - returns current value.
- `setValue(value: string)` - sets new value.
- `show()` - makes question section visible if it was previosly hidden via frontend API.
- `hide()` - hides question section.
- `onChange(handler)` - event is triggered on focus out and value is changed.
- `offChange(handler)` - unsubscribe from change event.

### Separator

- `show()` - makes question section visible if it was previosly hidden via frontend API.
- `hide()` - hides question section.

### File Upload

- `getValue(): number` - returns media id.
- `setValue(mediaId: number): Promise` - sets new value. Returns [Promise](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Promise) which will be resolved if media id is valid and rejected if media id doesn't exist or access to media is forbidden for current user.
- `getUrl(): string` - returns url to uploaded file.
- `show()` - makes question section visible if it was previosly hidden via frontend API.
- `hide()` - hides question section.
- `uploadFile(file: File): Promise` - upload [File](https://developer.mozilla.org/en-US/docs/Web/API/File) to Filestack. Returns Promise which is resolved when upload is succeeded.
- `onChange(handler)` - event is triggered when file is uploaded or deleted.
- `offChange(handler)` - unsubscribe from change event.

### Checkbox List

- `getValue(): string[]` - returns array of selected item text.
- `setValue(listItemText: string[])` - check items which are presented in array, uncheck if they are not in array.
- `show()` - makes question section visible if it was previosly hidden via frontend API.
- `hide()` - hides question section.
- `onChange(handler)` - event is triggered on check/uncheck of any checkbox.
- `offChange(handler)` - unsubscribe from change event.

## Change event handler

- `handler: (oldValue, newValue) => ({ canceled: boolean, message: string })` - to cancel value change return object with `canceled: true` property, to show alert with message return `message` in result object.
- Now only one handler can be attached to event.
- Calling `offChange()` with no arguments removes handler attached to the field.
- Example:

```
var handler = function (oldValue, newValue) {
    console.log("changed", oldValue, newValue);
}

fieldApi.onChange(handler);
fieldApi.offChange(handler); // handler is removed

fieldApi.onChange(handler);
fieldApi.offChange(); // handler is removed

fieldApi.onChange(handler);
fieldApi.offChange("123"); // throws exception 'Handler is not a function.'
```
