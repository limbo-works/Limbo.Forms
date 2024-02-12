# EmailField

<table class="table details lined">
    <tr>
        <th>Extends</th>
        <td><code>FieldBase</code></td>
    </tr>
    <tr>
        <th>Namespace</th>
        <td><code>Limbo.Forms.Models.Fields</code></td>
    </tr>
    <tr>
        <th>Type</th>
        <td><code>email</code></td>
    </tr>
</table>

The `EmailField` class represents a HTML `<input />` element with it's `type` attribute set to `email`. 

## Properties

The class extends the `InputField` class, thus inheriting it's properties from both `InputField` and `FieldBase`. `EmailField` doesn't have any properties of it's own.

<table class="table list border zebra">
    <thead>
        <tr>
            <th>C#&nbsp;Name</th>
            <th>C#&nbsp;Type</th>
            <th>JSON&nbsp;Name</th>
            <th>Description</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td><code>Type</code></td>
            <td><code>string</code></td>
            <td><code>type</code></td>
            <td>
                <em>Inherited from the <code>FieldBase</code> class.</em><br />
                The type of the field - generally matching the HTML <c>type</c> attribute, or a custom value for non-HTML fields.
            </td>
        </tr>
        <tr>
            <td><code>Name</code></td>
            <td><code>string</code></td>
            <td><code>name</code></td>
            <td>
                <em>Inherited from the <code>FieldBase</code> class.</em><br />
                The name of the field - matching the value for the HTML `name` attribute.
            </td>
        </tr>
        <tr>
            <td><code>Label</code></td>
            <td><code>string</code></td>
            <td><code>label</code></td>
            <td>
                <em>Inherited from the <code>FieldBase</code> class.</em><br />
                A friendly name that should accompany the field.
            </td>
        </tr>
        <tr>
            <td><code>Description</code></td>
            <td><code>string</code></td>
            <td><code>description</code></td>
            <td>
                <em>Inherited from the <code>FieldBase</code> class.</em><br />
                A description that should accompany the field.
            </td>
        </tr>
        <tr>
            <td><code>IsRequired</code></td>
            <td><code>bool</code></td>
            <td><code>required</code></td>
            <td>
                <em>Inherited from the <code>FieldBase</code> class.</em><br />
                Whether the field is required/mandatory.
            </td>
        </tr>
        <tr>
            <td><code>Value</code></td>
            <td><code>object</code></td>
            <td><code>value</code></td>
            <td>
                <em>Inherited from the <code>FieldBase</code> class.</em><br />
                An optional value of the field.
            </td>
        </tr>
        <tr>
            <td><code>Placeholder</code></td>
            <td><code>string</code></td>
            <td><code>placeholder</code></td>
            <td>
                <em>Inherited from the <code>InputField</code> class.</em><br />
                The value for the HTML <code>placeholder</code> attribute.
            </td>
        </tr>
        <tr>
            <td><code>Pattern</code></td>
            <td><code>bool</code></td>
            <td><code>pattern</code></td>
            <td>
                <em>Inherited from the <code>InputField</code> class.</em><br />
                The value for the HTML <code>pattern</code> attribute (aka a REGEX pattern used to validate the field).
            </td>
        </tr>
        <tr>
            <td><code>Size</code></td>
            <td><code>int?</code></td>
            <td><code>size</code></td>
            <td>
                <em>Inherited from the <code>InputField</code> class.</em><br />
                The value for the HTML <code>size</code> attribute.
            </td>
        </tr>
    </tbody>
</table>

## JSON Output

```json
{
  "type": "email",
  "name": "emailField",
  "label": "Your email",
  "description": "Enter your email address.",
  "required": true,
  "placeholder": "Enter your email address.",
  "pattern": "bb|[^b]{2}",
  "size": 9001,
  "value": "hello@example.org"
}
```