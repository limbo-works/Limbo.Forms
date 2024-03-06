﻿using System.Collections.Generic;

namespace Limbo.Forms.Models.Fields;

/// <summary>
/// Class representing a <c>dropdown</c> list based field.
/// </summary>
public class DropDownList : ListBase {

    /// <summary>
    /// Gets the type of buttons based on <see cref="DropDownList"/>.
    /// </summary>
    protected const string FieldType = "dropdown";

    #region Constructors

    /// <summary>
    /// Initializes a new drop-down list with default values.
    /// </summary>
    public DropDownList() : base(FieldType) { }

    /// <summary>
    /// Initializes a new drop-down list with the specified <paramref name="name"/>.
    /// </summary>
    /// <param name="name">The name of the drop-down list.</param>
    public DropDownList(string name) : base(FieldType, name) { }

    /// <summary>
    /// Initializes a new drop-down list with the specified <paramref name="name"/> and <paramref name="items"/>.
    /// </summary>
    /// <param name="name">The name of the drop-down list.</param>
    /// <param name="items">The items that should make up the drop-down list.</param>
    public DropDownList(string name, IEnumerable<ListItem>? items) : base(FieldType, name, null, items) { }

    /// <summary>
    /// Initializes a new drop-down list with the specified <paramref name="name"/> and <paramref name="items"/>.
    /// </summary>
    /// <param name="name">The name of the drop-down list.</param>
    /// <param name="items">The items that should make up the drop-down list.</param>
    public DropDownList(string name, params ListItem[] items) : base(FieldType, name, null, items) { }

    /// <summary>
    /// Initializes a new drop-down list with the specified <paramref name="name"/> and <paramref name="label"/>.
    /// </summary>
    /// <param name="name">The name of the drop-down list.</param>
    /// <param name="label">The label of the drop-down list.</param>
    public DropDownList(string name, string? label) : base(FieldType, name, label) { }

    /// <summary>
    /// Initializes a new drop-down list with the specified <paramref name="name"/>, <paramref name="label"/> and <paramref name="items"/>.
    /// </summary>
    /// <param name="name">The name of the drop-down list.</param>
    /// <param name="label">The label of the drop-down list.</param>
    /// <param name="items">The items that should make up the drop-down list.</param>
    public DropDownList(string name, string? label, IEnumerable<ListItem>? items) : base(FieldType, name, label, items) { }

    /// <summary>
    /// Initializes a new drop-down list with the specified <paramref name="name"/>, <paramref name="label"/> and <paramref name="items"/>.
    /// </summary>
    /// <param name="name">The name of the drop-down list.</param>
    /// <param name="label">The label of the drop-down list.</param>
    /// <param name="items">The items that should make up the drop-down list.</param>
    public DropDownList(string name, string? label, params ListItem[] items) : base(FieldType, name, label, items) { }

    #endregion

    #region Static methods

    /// <summary>
    /// Initializes a new drop-down list field with default values.
    /// </summary>
    /// <returns>An instance of <see cref="DropDownList"/>.</returns>
    public static DropDownList Create() {
        return new DropDownList();
    }

    /// <summary>
    /// Initializes a new drop-down list field with the specified <paramref name="name"/>.
    /// </summary>
    /// <param name="name">The name of the field.</param>
    /// <param name="label">The label of the field.</param>
    /// <param name="description">The description of the field.</param>
    /// <param name="placeholder">The placeholder text to be used for the field.</param>
    /// <param name="value">The initial value of the field.</param>
    /// <param name="id">The ID of the field.</param>
    /// <param name="required">Whether the field list is required.</param>
    /// <param name="disabled">Whether the field list is disabled.</param>
    /// <param name="items">The items that should make up the índividual items of the list.</param>
    /// <returns>An instance of <see cref="DropDownList"/>.</returns>
    public static DropDownList Create(string name, string? label = null, string? description = null, string? placeholder = null, object? value = null, string? id = null, bool? required = false, bool? disabled = false, IEnumerable<ListItem>? items = null) {
        return new DropDownList(name, items) {
            Id = id,
            Label = label,
            Description = description,
            Placeholder = placeholder,
            Value = value,
            IsRequired = required is true,
            IsDisabled = disabled is true
        };
    }

    /// <summary>
    /// Initializes a new drop-down list field with the specified <paramref name="name"/>.
    /// </summary>
    /// <param name="name">The name of the field.</param>
    /// <param name="label">The label of the field.</param>
    /// <param name="description">The description of the field.</param>
    /// <param name="placeholder">The placeholder text to be used for the field.</param>
    /// <param name="value">The initial value of the field.</param>
    /// <param name="id">The ID of the field.</param>
    /// <param name="required">Whether the field list is required.</param>
    /// <param name="disabled">Whether the field list is disabled.</param>
    /// <param name="items">The items that should make up the índividual items of the list.</param>
    /// <returns>An instance of <see cref="DropDownList"/>.</returns>
    public static DropDownList Create(string name, string? label = null, string? description = null, string? placeholder = null, object? value = null, string? id = null, bool? required = false, bool? disabled = false, params ListItem[] items) {
        return new DropDownList(name, items) {
            Id = id,
            Label = label,
            Description = description,
            Placeholder = placeholder,
            Value = value,
            IsRequired = required is true,
            IsDisabled = disabled is true
        };
    }

    #endregion

}