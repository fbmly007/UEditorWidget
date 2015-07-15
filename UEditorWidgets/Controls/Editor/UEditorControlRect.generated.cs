
//This code generated by tool. Do not hand update!
//ALSO DO NOT DELETE OR YOU WILL LOOSE YOUR FORM!
namespace uAssist.UEditorWidgets
{
    using UnityEngine;
    using UnityEditor;
    using System.Collections;
    using System.Collections.Generic;

    public partial class UEditorControlRect : UEditorWidgetBase
    {

        //Widget declarations
		private UEditorWidgetFoldout _controlFoldout = UWidget.Create<UEditorWidgetFoldout>();
        private UEditorPanelVertical _controlGroup = UWidget.Create<UEditorPanelVertical>();
		private UEditorPanelHorizonal _renderLine1 = UWidget.Create<UEditorPanelHorizonal>();
		private UEditorPanelHorizonal _renderLine2 = UWidget.Create<UEditorPanelHorizonal>();
		private UEditorPanelHorizonal HorizontalLayout = UWidget.Create<UEditorPanelHorizonal>();
		private UEditorWidgetLabel LabelControl2 = UWidget.Create<UEditorWidgetLabel>();
		private UEditorWidgetTextField _inputLeft = UWidget.Create<UEditorWidgetTextField>("", true);
		private UEditorWidgetLabel LabelControl3 = UWidget.Create<UEditorWidgetLabel>();
        private UEditorWidgetTextField _inputRight = UWidget.Create<UEditorWidgetTextField>("", true);
		private UEditorWidgetLabel LabelControl = UWidget.Create<UEditorWidgetLabel>();
        private UEditorWidgetTextField _inputTop = UWidget.Create<UEditorWidgetTextField>("", true);
		private UEditorWidgetLabel LabelControl1 = UWidget.Create<UEditorWidgetLabel>();
        private UEditorWidgetTextField _inputBottom = UWidget.Create<UEditorWidgetTextField>("", true);


        public void InitalizeComponents()
        {

            
        //Property settings
		//Property setters for ->_controlFoldout
		this._controlFoldout.FoldoutOpen = false;
		this._controlFoldout.FontSize = 11;
		this._controlFoldout.FontStyle = UnityEngine.FontStyle.Normal;
		this._controlFoldout.Label = "Foldout";
		this._controlFoldout.BaseStyle = "";
		this._controlFoldout.Clipping = UnityEngine.TextClipping.Overflow;
		this._controlFoldout.Margin.top = 0;
		this._controlFoldout.Margin.bottom = 0;
		this._controlFoldout.Margin.left = 0;
		this._controlFoldout.Margin.right = 0;
		this._controlFoldout.Padding.top = 0;
		this._controlFoldout.Padding.bottom = 0;
		this._controlFoldout.Padding.left = 15;
		this._controlFoldout.Padding.right = 0;
		this._controlFoldout.Border.top = 13;
		this._controlFoldout.Border.bottom = 0;
		this._controlFoldout.Border.left = 14;
		this._controlFoldout.Border.right = 0;
		this._controlFoldout.Height = -1f;
		this._controlFoldout.Width = 200f;
		this._controlFoldout.Name = "_controlFoldout";
		this._controlFoldout.IndentLevel = 0;
		this._controlFoldout.IndentDepth = 10;
		this._controlFoldout.DefaultWidth = 200f;
		this._controlFoldout.ToggleOnLabelClick = true;
		this._controlFoldout.Override_AlwaysOpen = false;
		this._controlFoldout.ChildrenShouldRender = true;
		this._controlFoldout.PositionX = 1f;
		this._controlFoldout.PositionY = 1f;
		this._controlFoldout.GUIEnabled = true;
		this._controlFoldout.WidgetShouldRender = true;
		this._controlFoldout.LayoutExpandHeight = false;
		this._controlFoldout.LayoutExpandWidth = false;
		this._controlFoldout.LayoutMode = uAssist.UEditorWidgets.ePositioningLayout.Layout;
	
	
		//Property setters for ->_controlGroup
		this._controlGroup.BaseStyle = "";
		this._controlGroup.Clipping = UnityEngine.TextClipping.Overflow;
		this._controlGroup.Margin.top = 0;
		this._controlGroup.Margin.bottom = 0;
		this._controlGroup.Margin.left = 15;
		this._controlGroup.Margin.right = 0;
		this._controlGroup.Padding.top = 0;
		this._controlGroup.Padding.bottom = 0;
		this._controlGroup.Padding.left = 0;
		this._controlGroup.Padding.right = 0;
		this._controlGroup.Border.top = 0;
		this._controlGroup.Border.bottom = 0;
		this._controlGroup.Border.left = 0;
		this._controlGroup.Border.right = 0;
		this._controlGroup.Height = 40f;
		this._controlGroup.Width = 200f;
		this._controlGroup.Name = "_controlGroup";
		this._controlGroup.ChildrenShouldRender = true;
		this._controlGroup.PositionX = 0f;
		this._controlGroup.PositionY = 0f;
		this._controlGroup.GUIEnabled = true;
		this._controlGroup.WidgetShouldRender = true;
		this._controlGroup.LayoutExpandHeight = false;
		this._controlGroup.LayoutExpandWidth = false;
        this._controlGroup.LayoutMode = uAssist.UEditorWidgets.ePositioningLayout.Layout;
		this._controlFoldout.AddChild(this._controlGroup);
	
	
		//Property setters for ->_renderLine1
		this._renderLine1.BaseStyle = "";
		this._renderLine1.Clipping = UnityEngine.TextClipping.Overflow;
		this._renderLine1.Margin.top = 0;
		this._renderLine1.Margin.bottom = 0;
		this._renderLine1.Margin.left = 0;
		this._renderLine1.Margin.right = 0;
		this._renderLine1.Padding.top = 0;
		this._renderLine1.Padding.bottom = 0;
		this._renderLine1.Padding.left = 0;
		this._renderLine1.Padding.right = 0;
		this._renderLine1.Border.top = 0;
		this._renderLine1.Border.bottom = 0;
		this._renderLine1.Border.left = 0;
		this._renderLine1.Border.right = 0;
		this._renderLine1.Height = -1f;
		this._renderLine1.Width = -1f;
		this._renderLine1.Name = "_renderLine1";
		this._renderLine1.ChildrenShouldRender = true;
		this._renderLine1.PositionX = 1f;
		this._renderLine1.PositionY = 1f;
		this._renderLine1.GUIEnabled = true;
		this._renderLine1.WidgetShouldRender = true;
		this._renderLine1.LayoutExpandHeight = false;
		this._renderLine1.LayoutExpandWidth = false;
        this._renderLine1.LayoutMode = uAssist.UEditorWidgets.ePositioningLayout.Layout;
		this._controlGroup.AddChild(this._renderLine1);
	
	
		//Property setters for ->_renderLine2
		this._renderLine2.BaseStyle = "";
		this._renderLine2.Clipping = UnityEngine.TextClipping.Overflow;
		this._renderLine2.Margin.top = 0;
		this._renderLine2.Margin.bottom = 0;
		this._renderLine2.Margin.left = 0;
		this._renderLine2.Margin.right = 0;
		this._renderLine2.Padding.top = 0;
		this._renderLine2.Padding.bottom = 0;
		this._renderLine2.Padding.left = 0;
		this._renderLine2.Padding.right = 0;
		this._renderLine2.Border.top = 0;
		this._renderLine2.Border.bottom = 0;
		this._renderLine2.Border.left = 0;
		this._renderLine2.Border.right = 0;
		this._renderLine2.Height = -1f;
		this._renderLine2.Width = -1f;
		this._renderLine2.Name = "_renderLine2";
		this._renderLine2.ChildrenShouldRender = true;
		this._renderLine2.PositionX = 1f;
		this._renderLine2.PositionY = 1f;
		this._renderLine2.GUIEnabled = true;
		this._renderLine2.WidgetShouldRender = true;
		this._renderLine2.LayoutExpandHeight = false;
		this._renderLine2.LayoutExpandWidth = false;
		this._renderLine2.LayoutMode = uAssist.UEditorWidgets.ePositioningLayout.Layout;
		this._controlGroup.AddChild(this._renderLine2);
	
	
		//Property setters for ->HorizontalLayout
		this.HorizontalLayout.BaseStyle = "";
		this.HorizontalLayout.Clipping = UnityEngine.TextClipping.Overflow;
		this.HorizontalLayout.Margin.top = 0;
		this.HorizontalLayout.Margin.bottom = 0;
		this.HorizontalLayout.Margin.left = 0;
		this.HorizontalLayout.Margin.right = 0;
		this.HorizontalLayout.Padding.top = 0;
		this.HorizontalLayout.Padding.bottom = 0;
		this.HorizontalLayout.Padding.left = 0;
		this.HorizontalLayout.Padding.right = 0;
		this.HorizontalLayout.Border.top = 0;
		this.HorizontalLayout.Border.bottom = 0;
		this.HorizontalLayout.Border.left = 0;
		this.HorizontalLayout.Border.right = 0;
		this.HorizontalLayout.Height = -1f;
		this.HorizontalLayout.Width = -1f;
		this.HorizontalLayout.Name = "HorizontalLayout";
		this.HorizontalLayout.ChildrenShouldRender = true;
		this.HorizontalLayout.PositionX = 1f;
		this.HorizontalLayout.PositionY = 1f;
		this.HorizontalLayout.GUIEnabled = true;
		this.HorizontalLayout.WidgetShouldRender = true;
		this.HorizontalLayout.LayoutExpandHeight = false;
		this.HorizontalLayout.LayoutExpandWidth = false;
		this.HorizontalLayout.LayoutMode = uAssist.UEditorWidgets.ePositioningLayout.Layout;
		this._renderLine1.AddChild(this.HorizontalLayout);
	
	
		//Property setters for ->LabelControl2
		this.LabelControl2.Label = "Left";
		this.LabelControl2.FontSize = 11;
		this.LabelControl2.FontStyle = UnityEngine.FontStyle.Normal;
		this.LabelControl2.WordWrap = false;
		this.LabelControl2.Alignment = UnityEngine.TextAnchor.UpperLeft;
		this.LabelControl2.BaseStyle = "";
		this.LabelControl2.Clipping = UnityEngine.TextClipping.Overflow;
		this.LabelControl2.Margin.top = 2;
		this.LabelControl2.Margin.bottom = 2;
		this.LabelControl2.Margin.left = 4;
		this.LabelControl2.Margin.right = 4;
		this.LabelControl2.Padding.top = 1;
		this.LabelControl2.Padding.bottom = 2;
		this.LabelControl2.Padding.left = 3;
		this.LabelControl2.Padding.right = 3;
		this.LabelControl2.Border.top = 0;
		this.LabelControl2.Border.bottom = 0;
		this.LabelControl2.Border.left = 0;
		this.LabelControl2.Border.right = 0;
		this.LabelControl2.Height = -1f;
		this.LabelControl2.Width = 30f;
		this.LabelControl2.Name = "LabelControl2";
		this.LabelControl2.PositionX = 1f;
		this.LabelControl2.PositionY = 1f;
		this.LabelControl2.GUIEnabled = true;
		this.LabelControl2.WidgetShouldRender = true;
		this.LabelControl2.LayoutExpandHeight = false;
		this.LabelControl2.LayoutExpandWidth = false;
		this.LabelControl2.LayoutMode = uAssist.UEditorWidgets.ePositioningLayout.Layout;
		this._renderLine2.AddChild(this.LabelControl2);
	
	
		//Property setters for ->_inputLeft
		this._inputLeft.Text = "";
		this._inputLeft.FontSize = 11;
		this._inputLeft.FontStyle = UnityEngine.FontStyle.Normal;
		this._inputLeft.WordWrap = false;
		this._inputLeft.Alignment = UnityEngine.TextAnchor.UpperLeft;
		this._inputLeft.BaseStyle = "";
		this._inputLeft.Clipping = UnityEngine.TextClipping.Overflow;
		this._inputLeft.Margin.top = 2;
		this._inputLeft.Margin.bottom = 2;
		this._inputLeft.Margin.left = 4;
		this._inputLeft.Margin.right = 4;
		this._inputLeft.Padding.top = 1;
		this._inputLeft.Padding.bottom = 2;
		this._inputLeft.Padding.left = 3;
		this._inputLeft.Padding.right = 3;
		this._inputLeft.Border.top = 3;
		this._inputLeft.Border.bottom = 3;
		this._inputLeft.Border.left = 3;
		this._inputLeft.Border.right = 3;
		this._inputLeft.Height = 16f;
		this._inputLeft.Width = 50f;
		this._inputLeft.Name = "_inputLeft";
		this._inputLeft.PositionX = 1f;
		this._inputLeft.PositionY = 1f;
		this._inputLeft.GUIEnabled = true;
		this._inputLeft.WidgetShouldRender = true;
		this._inputLeft.LayoutExpandHeight = false;
		this._inputLeft.LayoutExpandWidth = false;
		this._inputLeft.LayoutMode = uAssist.UEditorWidgets.ePositioningLayout.Layout;
		this._renderLine2.AddChild(this._inputLeft);
	
	
		//Property setters for ->LabelControl3
		this.LabelControl3.Label = "Right";
		this.LabelControl3.FontSize = 11;
		this.LabelControl3.FontStyle = UnityEngine.FontStyle.Normal;
		this.LabelControl3.WordWrap = false;
		this.LabelControl3.Alignment = UnityEngine.TextAnchor.UpperLeft;
		this.LabelControl3.BaseStyle = "";
		this.LabelControl3.Clipping = UnityEngine.TextClipping.Overflow;
		this.LabelControl3.Margin.top = 2;
		this.LabelControl3.Margin.bottom = 2;
		this.LabelControl3.Margin.left = 4;
		this.LabelControl3.Margin.right = 4;
		this.LabelControl3.Padding.top = 1;
		this.LabelControl3.Padding.bottom = 2;
		this.LabelControl3.Padding.left = 3;
		this.LabelControl3.Padding.right = 3;
		this.LabelControl3.Border.top = 0;
		this.LabelControl3.Border.bottom = 0;
		this.LabelControl3.Border.left = 0;
		this.LabelControl3.Border.right = 0;
		this.LabelControl3.Height = -1f;
		this.LabelControl3.Width = 45f;
		this.LabelControl3.Name = "LabelControl3";
		this.LabelControl3.PositionX = 1f;
		this.LabelControl3.PositionY = 1f;
		this.LabelControl3.GUIEnabled = true;
		this.LabelControl3.WidgetShouldRender = true;
		this.LabelControl3.LayoutExpandHeight = false;
		this.LabelControl3.LayoutExpandWidth = false;
		this.LabelControl3.LayoutMode = uAssist.UEditorWidgets.ePositioningLayout.Layout;
		this._renderLine2.AddChild(this.LabelControl3);
	
	
		//Property setters for ->_inputRight
		this._inputRight.Text = "";
		this._inputRight.FontSize = 11;
		this._inputRight.FontStyle = UnityEngine.FontStyle.Normal;
		this._inputRight.WordWrap = false;
		this._inputRight.Alignment = UnityEngine.TextAnchor.UpperLeft;
		this._inputRight.BaseStyle = "";
		this._inputRight.Clipping = UnityEngine.TextClipping.Overflow;
		this._inputRight.Margin.top = 2;
		this._inputRight.Margin.bottom = 2;
		this._inputRight.Margin.left = 4;
		this._inputRight.Margin.right = 4;
		this._inputRight.Padding.top = 1;
		this._inputRight.Padding.bottom = 2;
		this._inputRight.Padding.left = 3;
		this._inputRight.Padding.right = 3;
		this._inputRight.Border.top = 3;
		this._inputRight.Border.bottom = 3;
		this._inputRight.Border.left = 3;
		this._inputRight.Border.right = 3;
		this._inputRight.Height = 16f;
		this._inputRight.Width = 50f;
		this._inputRight.Name = "_inputRight";
		this._inputRight.PositionX = 1f;
		this._inputRight.PositionY = 1f;
		this._inputRight.GUIEnabled = true;
		this._inputRight.WidgetShouldRender = true;
		this._inputRight.LayoutExpandHeight = false;
		this._inputRight.LayoutExpandWidth = false;
		this._inputRight.LayoutMode = uAssist.UEditorWidgets.ePositioningLayout.Layout;
		this._renderLine2.AddChild(this._inputRight);
	
	
		//Property setters for ->LabelControl
		this.LabelControl.Label = "Top";
		this.LabelControl.FontSize = 11;
		this.LabelControl.FontStyle = UnityEngine.FontStyle.Normal;
		this.LabelControl.WordWrap = false;
		this.LabelControl.Alignment = UnityEngine.TextAnchor.UpperLeft;
		this.LabelControl.BaseStyle = "";
		this.LabelControl.Clipping = UnityEngine.TextClipping.Overflow;
		this.LabelControl.Margin.top = 2;
		this.LabelControl.Margin.bottom = 2;
		this.LabelControl.Margin.left = 4;
		this.LabelControl.Margin.right = 4;
		this.LabelControl.Padding.top = 1;
		this.LabelControl.Padding.bottom = 2;
		this.LabelControl.Padding.left = 3;
		this.LabelControl.Padding.right = 3;
		this.LabelControl.Border.top = 0;
		this.LabelControl.Border.bottom = 0;
		this.LabelControl.Border.left = 0;
		this.LabelControl.Border.right = 0;
		this.LabelControl.Height = -1f;
		this.LabelControl.Width = 30f;
		this.LabelControl.Name = "LabelControl";
		this.LabelControl.PositionX = 1f;
		this.LabelControl.PositionY = 1f;
		this.LabelControl.GUIEnabled = true;
		this.LabelControl.WidgetShouldRender = true;
		this.LabelControl.LayoutExpandHeight = false;
		this.LabelControl.LayoutExpandWidth = false;
		this.LabelControl.LayoutMode = uAssist.UEditorWidgets.ePositioningLayout.Layout;
		this.HorizontalLayout.AddChild(this.LabelControl);
	
	
		//Property setters for ->_inputTop
		this._inputTop.Text = "";
		this._inputTop.FontSize = 11;
		this._inputTop.FontStyle = UnityEngine.FontStyle.Normal;
		this._inputTop.WordWrap = false;
		this._inputTop.Alignment = UnityEngine.TextAnchor.UpperLeft;
		this._inputTop.BaseStyle = "";
		this._inputTop.Clipping = UnityEngine.TextClipping.Overflow;
		this._inputTop.Margin.top = 2;
		this._inputTop.Margin.bottom = 2;
		this._inputTop.Margin.left = 4;
		this._inputTop.Margin.right = 4;
		this._inputTop.Padding.top = 1;
		this._inputTop.Padding.bottom = 2;
		this._inputTop.Padding.left = 3;
		this._inputTop.Padding.right = 3;
		this._inputTop.Border.top = 3;
		this._inputTop.Border.bottom = 3;
		this._inputTop.Border.left = 3;
		this._inputTop.Border.right = 3;
		this._inputTop.Height = 16f;
		this._inputTop.Width = 50f;
		this._inputTop.Name = "_inputTop";
		this._inputTop.PositionX = 1f;
		this._inputTop.PositionY = 1f;
		this._inputTop.GUIEnabled = true;
		this._inputTop.WidgetShouldRender = true;
		this._inputTop.LayoutExpandHeight = false;
		this._inputTop.LayoutExpandWidth = false;
		this._inputTop.LayoutMode = uAssist.UEditorWidgets.ePositioningLayout.Layout;
		this.HorizontalLayout.AddChild(this._inputTop);
	
	
		//Property setters for ->LabelControl1
		this.LabelControl1.Label = "Bottom";
		this.LabelControl1.FontSize = 11;
		this.LabelControl1.FontStyle = UnityEngine.FontStyle.Normal;
		this.LabelControl1.WordWrap = false;
		this.LabelControl1.Alignment = UnityEngine.TextAnchor.UpperLeft;
		this.LabelControl1.BaseStyle = "";
		this.LabelControl1.Clipping = UnityEngine.TextClipping.Overflow;
		this.LabelControl1.Margin.top = 2;
		this.LabelControl1.Margin.bottom = 2;
		this.LabelControl1.Margin.left = 4;
		this.LabelControl1.Margin.right = 4;
		this.LabelControl1.Padding.top = 1;
		this.LabelControl1.Padding.bottom = 2;
		this.LabelControl1.Padding.left = 3;
		this.LabelControl1.Padding.right = 3;
		this.LabelControl1.Border.top = 0;
		this.LabelControl1.Border.bottom = 0;
		this.LabelControl1.Border.left = 0;
		this.LabelControl1.Border.right = 0;
		this.LabelControl1.Height = -1f;
		this.LabelControl1.Width = 45f;
		this.LabelControl1.Name = "LabelControl1";
		this.LabelControl1.PositionX = 1f;
		this.LabelControl1.PositionY = 1f;
		this.LabelControl1.GUIEnabled = true;
		this.LabelControl1.WidgetShouldRender = true;
		this.LabelControl1.LayoutExpandHeight = false;
		this.LabelControl1.LayoutExpandWidth = false;
		this.LabelControl1.LayoutMode = uAssist.UEditorWidgets.ePositioningLayout.Layout;
		this.HorizontalLayout.AddChild(this.LabelControl1);
	
	
		//Property setters for ->_inputBottom
		this._inputBottom.Text = "";
		this._inputBottom.FontSize = 11;
		this._inputBottom.FontStyle = UnityEngine.FontStyle.Normal;
		this._inputBottom.WordWrap = false;
		this._inputBottom.Alignment = UnityEngine.TextAnchor.UpperLeft;
		this._inputBottom.BaseStyle = "";
		this._inputBottom.Clipping = UnityEngine.TextClipping.Overflow;
		this._inputBottom.Margin.top = 2;
		this._inputBottom.Margin.bottom = 2;
		this._inputBottom.Margin.left = 4;
		this._inputBottom.Margin.right = 4;
		this._inputBottom.Padding.top = 1;
		this._inputBottom.Padding.bottom = 2;
		this._inputBottom.Padding.left = 3;
		this._inputBottom.Padding.right = 3;
		this._inputBottom.Border.top = 3;
		this._inputBottom.Border.bottom = 3;
		this._inputBottom.Border.left = 3;
		this._inputBottom.Border.right = 3;
		this._inputBottom.Height = 16f;
		this._inputBottom.Width = 50f;
		this._inputBottom.Name = "_inputBottom";
		this._inputBottom.PositionX = 1f;
		this._inputBottom.PositionY = 1f;
		this._inputBottom.GUIEnabled = true;
		this._inputBottom.WidgetShouldRender = true;
		this._inputBottom.LayoutExpandHeight = false;
		this._inputBottom.LayoutExpandWidth = false;
		this._inputBottom.LayoutMode = uAssist.UEditorWidgets.ePositioningLayout.Layout;
		this.HorizontalLayout.AddChild(this._inputBottom);
	
	


        }

    }
}