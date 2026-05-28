---
name: Pro Management Suite
colors:
  surface: '#f8f9fa'
  surface-dim: '#d9dadb'
  surface-bright: '#f8f9fa'
  surface-container-lowest: '#ffffff'
  surface-container-low: '#f3f4f5'
  surface-container: '#edeeef'
  surface-container-high: '#e7e8e9'
  surface-container-highest: '#e1e3e4'
  on-surface: '#191c1d'
  on-surface-variant: '#414754'
  inverse-surface: '#2e3132'
  inverse-on-surface: '#f0f1f2'
  outline: '#717786'
  outline-variant: '#c1c6d7'
  surface-tint: '#005bc0'
  primary: '#0059bb'
  on-primary: '#ffffff'
  primary-container: '#0070ea'
  on-primary-container: '#fefcff'
  inverse-primary: '#adc7ff'
  secondary: '#575f67'
  on-secondary: '#ffffff'
  secondary-container: '#d8e1ea'
  on-secondary-container: '#5b646b'
  tertiary: '#9e3d00'
  on-tertiary: '#ffffff'
  tertiary-container: '#c64f00'
  on-tertiary-container: '#fffbff'
  error: '#ba1a1a'
  on-error: '#ffffff'
  error-container: '#ffdad6'
  on-error-container: '#93000a'
  primary-fixed: '#d8e2ff'
  primary-fixed-dim: '#adc7ff'
  on-primary-fixed: '#001a41'
  on-primary-fixed-variant: '#004493'
  secondary-fixed: '#dbe4ed'
  secondary-fixed-dim: '#bfc8d0'
  on-secondary-fixed: '#141d23'
  on-secondary-fixed-variant: '#3f484f'
  tertiary-fixed: '#ffdbcc'
  tertiary-fixed-dim: '#ffb695'
  on-tertiary-fixed: '#351000'
  on-tertiary-fixed-variant: '#7c2e00'
  background: '#f8f9fa'
  on-background: '#191c1d'
  surface-variant: '#e1e3e4'
typography:
  headline-lg:
    fontFamily: Inter
    fontSize: 24px
    fontWeight: '600'
    lineHeight: 32px
  headline-md:
    fontFamily: Inter
    fontSize: 18px
    fontWeight: '600'
    lineHeight: 24px
  body-md:
    fontFamily: Inter
    fontSize: 14px
    fontWeight: '400'
    lineHeight: 20px
  body-sm:
    fontFamily: Inter
    fontSize: 13px
    fontWeight: '400'
    lineHeight: 18px
  label-bold:
    fontFamily: Inter
    fontSize: 14px
    fontWeight: '700'
    lineHeight: 20px
  button-text:
    fontFamily: Inter
    fontSize: 14px
    fontWeight: '500'
    lineHeight: 20px
rounded:
  sm: 0.125rem
  DEFAULT: 0.25rem
  md: 0.375rem
  lg: 0.5rem
  xl: 0.75rem
  full: 9999px
spacing:
  base-unit: 4px
  container-padding: 20px
  gutter-md: 16px
  stack-sm: 8px
  stack-md: 16px
---

## Brand & Style

The design system is engineered for utility, efficiency, and clarity in administrative and data-heavy environments. It adopts a **Corporate / Modern** style that prioritizes content legibility and functional hierarchy over decorative elements. 

The visual language communicates reliability and precision through structured containers, consistent borders, and a balanced use of color to indicate system states. The atmosphere is professional and grounded, ensuring users can navigate complex information sets with minimal cognitive load. It is designed for SaaS platforms, internal tools, and management dashboards where task completion speed and data accuracy are paramount.

## Colors

The color palette is rooted in a functional "Signal & Surface" philosophy. 
- **Primary Blue (#007bff)** is used for main actions and indicative headers, providing a sense of trust.
- **Success, Danger, and Warning** colors follow industry standards to provide immediate semantic feedback for actions like editing, deleting, or status changes.
- **Neutral Grays** handle the structural heavy lifting: light grays (#e9ecef to #f8f9fa) define card backgrounds and table headers, while darker grays (#343a40) are reserved for body text and secondary icons.
- **Backgrounds** utilize a subtle off-white to reduce eye strain during long sessions, while white is reserved for interactive input fields and main content containers.

## Typography

This design system uses **Inter** for its exceptional legibility in data interfaces. The typographic hierarchy is tight and disciplined. 

Headlines use a semi-bold weight to distinguish sections clearly. Body text stays within a 13px-14px range to maximize the amount of information visible on screen without sacrificing readability. Labels for form fields are consistently bolded to anchor the user's eye during data entry. Numeric data in tables should utilize tabular lining (if available) to ensure vertical alignment of digits.

## Layout & Spacing

The layout follows a **Fixed-Fluid Hybrid** model. While the main containers (Cards) can expand to the width of the screen, they maintain internal fixed margins and padding to preserve whitespace.

- **Grid:** A 12-column grid is used for desktop, reflowing to a single column on mobile. 
- **Rhythm:** An 8px spacing scale is the standard for vertical stacking, while a 4px unit is used for tight internal component relationships (e.g., label to input).
- **Table Density:** Row heights are kept compact (approx. 48px) to allow for high data density, with 12px horizontal padding within cells.

## Elevation & Depth

This system avoids heavy shadows, instead relying on **Tonal Layers** and **Low-Contrast Outlines**.

- **Level 0 (Background):** A very light gray (#f4f4f4) surface.
- **Level 1 (Cards):** Pure white surfaces with a 1px solid border (#dee2e6). No shadow is used; the border provides sufficient definition.
- **Level 2 (Active States):** Subtle 2px blurs are only used on active "hover" states of buttons to indicate interactivity.
- **Headers:** Section headers within cards use a tinted background (#e7f1ff) to create a clear visual anchor for the content below.

## Shapes

The design system uses a **Soft (Level 1)** corner language. This 4px (0.25rem) radius strikes a balance between the precision of sharp corners and the friendliness of rounded ones.

- **Inputs & Buttons:** 4px radius.
- **Cards:** 4px radius with overflow hidden to ensure child headers align perfectly.
- **Data Tables:** Outer corners follow the card radius, while internal cells remain sharp to maintain a clean grid look.

## Components

### Buttons
Buttons use solid color fills with white text for high contrast. Icons (e.g., Plus, Edit, Trash) are placed to the left of the text label. Secondary buttons use a neutral gray background.

### Cards
Cards are the primary layout unit. They must include a header section with a subtle background color and a bolded title. The body of the card should have consistent internal padding (20px).

### Form Inputs
Inputs feature a 1px border (#ced4da) that darkens or turns blue on focus. Backgrounds for disabled or read-only IDs are light gray. Labels are placed above or to the left of the input, always using the `label-bold` style.

### Data Tables
Tables should include a light gray header row with centered or left-aligned text. Cell borders should be light and unobtrusive (#dee2e6). Action columns (e.g., Edit/Delete) should contain condensed buttons to save space.

### Chips/Badges
Used for status or counts, these utilize the semantic color palette with low-opacity backgrounds or solid fills depending on the required prominence.